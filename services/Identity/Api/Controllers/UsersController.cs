namespace Api;

using Application.Models.User;
using Application.Requests.User;
using MassTransit.Mediator;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class UsersController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> SearchAsync([FromBody] SearchUserRequest request)
    {
        var client = mediator.CreateRequestClient<SearchUserRequest>();
        var users = await client.GetResponse<SearchUserResponse>(request);
        return Ok(users);
    }

    [HttpPost]
    public async Task<ActionResult> RegisterAsync([FromBody] CreateUserRequest request)
    {
        var client = mediator.CreateRequestClient<CreateUserRequest>();
        var newUser = await client.GetResponse<CreateUserResponse>(request);
        return Ok(newUser);
    }

    [HttpPost("Sync")]
    public async Task<ActionResult> SyncUserToKeycloak()
    {
        await mediator.Send(new SyncUserToIdentityProviderRequest());
        return Ok();
    }
}