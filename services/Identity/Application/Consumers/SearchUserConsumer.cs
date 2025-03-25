namespace Application.Consumers;

using AutoMapper;
using MassTransit;
using Requests.User;
using Services.Abstractions;

public class SearchUserConsumer(
    IUserService userService,
    IIdentityProvider identityProvider,
    IMapper mapper
) : IConsumer<SearchUserRequest>
{
    public async Task Consume(ConsumeContext<SearchUserRequest> context)
    {
        var users = userService.Search(context.Message);
    }
}