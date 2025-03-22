namespace Api.Extensions;

using Domain.Enums;
using Keycloak.AuthServices.Authentication;
using Keycloak.AuthServices.Authorization;
using Keycloak.AuthServices.Common;
using Keycloak.AuthServices.Sdk;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Persistence.Database;
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

    public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IdentityDbContext>
        (
            opt => { opt.UseNpgsql(configuration["ConnectionString"]); }
        );
    }

    public static void UpdateDatabase(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<IdentityDbContext>();
        if (dbContext.Database.GetPendingMigrations().Any()) dbContext.Database.Migrate();
    }

    public static void AddKeycloakAuthenticationAndAuthorization(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddKeycloakWebApi(configuration);
        services
            .AddAuthorization()
            .AddKeycloakAuthorization(options =>
            {
                options.EnableRolesMapping =
                    RolesClaimTransformationSource.ResourceAccess;
                options.RolesResource = configuration["Keycloak:resource"];
            })
            .AddAuthorizationBuilder()
            .AddPolicy(
                nameof(UserRole.Admin),
                policy => policy.RequireRole(nameof(UserRole.Admin))
            );
    }

    public static void AddKeycloakAdminClient(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDistributedMemoryCache();
        var options = configuration.GetKeycloakOptions<KeycloakAdminClientOptions>()!;
        services
            .AddClientCredentialsTokenManagement()
            .AddClient(
                "keycloak.client",
                client =>
                {
                    client.ClientId = options.Resource;
                    client.ClientSecret = options.Credentials.Secret;
                    client.TokenEndpoint = options.KeycloakTokenEndpoint;
                }
            );
        services.AddKeycloakAdminHttpClient(configuration)
            .AddClientCredentialsTokenHandler("keycloak.client");
    }
}