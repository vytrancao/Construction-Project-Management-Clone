namespace Api.Extensions;

using System.Text.Json;
using Application.HttpClients;
using Application.Models.Keycloak;
using Refit;
using StackExchange.Redis;

public static class Startup
{
    public static void AddRedisCache(this IServiceCollection services)
    {
        services.AddScoped<IServer>(cfg =>
        {
            var multiplexer = ConnectionMultiplexer.Connect(Environment.GetEnvironmentVariable("cache")!);
            return multiplexer.GetServer("cache", 6379);
        });
    }

    public static void AddRefitClients(this IServiceCollection services)
    {
        services.AddRefitClient<IKeycloakClient>(new RefitSettings
            {
                AuthorizationHeaderValueGetter = async (message, token) =>
                {
                    var authToken = await AuthenticateKeycloakConsole(services);
                    Console.WriteLine(authToken);
                    return authToken!;
                }
            })
            .ConfigureHttpClient(x => x.BaseAddress = new Uri("http://keycloak:8080/admin/realms/cpm"));
    }

    private static async Task<string?> AuthenticateKeycloakConsole(IServiceCollection services)
    {
        var client = new HttpClient();
        var parameters = new Dictionary<string, string>
        {
            { "grant_type", "client_credentials" },
            { "client_id", "security-admin-console" },
            { "client_secret", "s6FokfrwAUixEVjzTHMBoBFxNF3niwva" }
        };
        var encodedContent = new FormUrlEncodedContent(parameters);

        var response = await client.PostAsync(
            $"http://keycloak:8080/realms/cpm/protocol/openid-connect/token",
            encodedContent);

        if (!response.IsSuccessStatusCode) return null;

        var content = await response.Content.ReadAsStringAsync();
        var token = JsonSerializer.Deserialize<AuthToken>(content);
        return token!.AccessToken;
    }
}