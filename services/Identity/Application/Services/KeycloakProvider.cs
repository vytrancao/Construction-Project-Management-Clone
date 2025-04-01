namespace Application.Services;

using Abstractions;
using Keycloak.AuthServices.Sdk.Admin;
using Keycloak.AuthServices.Sdk.Admin.Models;
using Microsoft.Extensions.Configuration;
using Models.Identity;
using Requests.User;

public class KeycloakProvider(
    IKeycloakClient keycloakClient,
    IConfiguration configuration
) : IIdentityProvider
{
    private readonly string _realm = configuration["Keycloak:realm"]!;

    public async Task<RegisteResponse> RegisterUser(CreateUserRequest request)
    {
        var newUser = request.ToIdentityRepresentation();
        var response = await keycloakClient.CreateUserWithResponseAsync(_realm, newUser);
        if (!response.IsSuccessStatusCode)
            throw new Exception(await response.Content.ReadAsStringAsync());

        var registerResponse = ExtractRegisterResponseFromHeader(response);
        var adminGroups = await GetGroup(request.Role.ToString());
        await keycloakClient.JoinGroupAsync(_realm, registerResponse.Id.ToString(), adminGroups.Id!);
        return registerResponse;
    }

    private static RegisteResponse ExtractRegisterResponseFromHeader(HttpResponseMessage responseMessage)
    {
        var header = responseMessage.Headers.First(x => x.Key == "Location");
        var uri = new Uri(header.Value.First());
        var userId = uri.Segments.Last().Trim('/');

        return new RegisteResponse(Guid.Parse(userId), uri);
    }

    private async Task<GroupRepresentation> GetGroup(string name)
    {
        var groups = await keycloakClient.GetGroupsAsync(_realm);
        return groups.First(x => x.Name == name);
    }
}