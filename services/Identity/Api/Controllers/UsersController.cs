namespace Api;

using Application.Models.User;
using Domain.Enums;
using Keycloak.AuthServices.Sdk.Admin;
using Keycloak.AuthServices.Sdk.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class UsersController(IKeycloakClient keycloakClient, IConfiguration configuration) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetUserAsync()
    {
        var realm = configuration["Keycloak:realm"];
        var users = await keycloakClient.GetUsersAsync(realm);
        return Ok(users);
    }

    [HttpPost]
    // [Authorize(Roles = "Admin")]
    public async Task<IActionResult> RegisterAsync()
    {
        var realm = configuration["Keycloak:realm"];
        var newUser = new User
        {
            Username = "vy",
            Email = "4@gmail.com",
            Enabled = true,
            FirstName = "Vy",
            LastName = "Tran",
            Credentials =
            [
                new CredentialRepresentation
                {
                    Type = "password",
                    Value = "admin",
                    Temporary = false
                }
            ],
            ClientRoles = new Dictionary<string, ICollection<string>> { ["security-admin-console"] = [nameof(UserRoles.Admin)] }
        };
        var response = await keycloakClient.CreateUserWithResponseAsync(realm, newUser);
        var content = response.Content.ReadAsStringAsync();
        var header = response.Headers.First(x => x.Key == "Location");
        var uri = new Uri(header.Value.First());
        var userId = uri.Segments.Last().Trim('/');
        // keycloakClient.User
        var groups = await keycloakClient.GetGroupsAsync("cpm");
        var adminGroups = groups.First(x => x.Name == nameof(UserRoles.Admin));
        await keycloakClient.JoinGroupAsync("cpm", userId, adminGroups.Id);
        return Created(uri, newUser);
    }
}