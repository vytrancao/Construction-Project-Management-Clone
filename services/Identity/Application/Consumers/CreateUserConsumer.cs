namespace Application.Consumers;

using MassTransit;
using Models.User;
using Requests.User;
using Services.Abstractions;

public class CreateUserConsumer(
    IUserService userService,
    IIdentityProvider identityProvider
) : IConsumer<CreateUserRequest>
{
    public async Task Consume(ConsumeContext<CreateUserRequest> context)
    {
        var request = context.Message;
        var registerResponse = await identityProvider.RegisterUser(request);

        request.Id = registerResponse.Id;
        var newUser = await userService.CreateAsync(request);

        var response = CreateUserResponse.FromEntity(newUser);
        response.CreatedUri = registerResponse.CreatedUri;

        await context.RespondAsync(response);
    }
}