namespace Api;

using Application.Contracts.User;
using Application.Models.User;
using Domain.Entities;
using Domain.Enums;
using MassTransit;
using MassTransit.Mediator;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class UsersController(
    ITopicProducer<UserCreateRequest> producer,
    IMediator mediator,
    ILogger<UsersController> logger) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> GetAsync()
    {
        producer.Produce(new UserCreateRequest(
            Email: "h",
            FirstName: "h",
            LastName: "h",
            Role: UserRole.Admin,
            Password: "h"
        ));

        return Ok();
    }

    [HttpPost]
    public async Task<ActionResult> RegisterAsync([FromBody] UserCreateRequest request)
    {
        var client = mediator.CreateRequestClient<UserCreateRequest>();

        var newUser = await client.GetResponse<UserCreateResponse>(request);

        return Ok(newUser);
    }
}