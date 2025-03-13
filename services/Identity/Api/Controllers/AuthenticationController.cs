namespace Api;

using Application.HttpClients;
using Application.Models.Keycloak;
using Application.Models.Keycloak.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
[Authorize]
public class AuthenticationController(IKeycloakClient keycloakClient) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> RegisterPrototype()
    {
        var request = new RegisterUserRequest
        {
            Username = "vy",
            Email = "3@gmail.com",
            Enabled = true,
            FirstName = "Vy",
            LastName = "Tran",
            Credentials =
            [
                new Credential
                {
                    Type = "password",
                    Value = "abc123",
                    Temporary = false
                }
            ]
        };

        var res = await keycloakClient.RegisterUser(request);
        return Ok(await res.Content.ReadAsStringAsync());
    }

    [HttpGet("hello")]
    public IActionResult HelloWorld()
    {
        return Ok("Hello World");
    }
}