namespace Api;

using Application.Models.User;
using Application.Requests.User;
using Application.Services.Abstractions;
using Cpm.Common.Messages.Identity;
using Microsoft.AspNetCore.Mvc;
using Rebus.Bus;

[Route("[controller]")]
[ApiController]
public class UsersController(
    IUserService userService,
    IIdentityProvider identityProvider,
    IBus bus
) : ControllerBase
{
    [HttpPost("Search")]
    public async Task<ActionResult> SearchAsync([FromBody] SearchUserRequest request)
    {
        var response = await userService.SearchAsync(request);

        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult> RegisterAsync([FromBody] CreateUserRequest request)
    {
        var registerResponse = await identityProvider.RegisterUser(request);

        request.Id = registerResponse.Id;
        var newUser = await userService.CreateAsync(request);

        var response = CreateUserResponse.FromEntity(newUser);
        response.CreatedUri = registerResponse.CreatedUri;

        return Ok(response);
    }

    [HttpPost("Sync")]
    public async Task<ActionResult> SyncUserToKeycloak()
    {
        await bus.Publish(new SyncIdentityUser());
        return Ok();
    }
}