namespace Application.Consumers;

using AutoMapper;
using Contracts.User;
using MassTransit;
using Models.User;
using Services.Abstractions;

public class CreateUserConsumer(
    IUserService userService,
    IIdentityProvider identityProvider,
    IMapper mapper
) : IConsumer<UserCreateRequest>
{
    public async Task Consume(ConsumeContext<UserCreateRequest> context)
    {
        var request = context.Message;
        var registerResponse = await identityProvider.RegisterUser(request);

        request.Id = registerResponse.Id;
        var newUser = await userService.CreateAsync(request);

        var response = mapper.Map<UserCreateResponse>(newUser);
        response.CreatedUri = registerResponse.CreatedUri;

        await context.RespondAsync(response);
    }
}