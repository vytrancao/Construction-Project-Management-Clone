namespace Application.Consumers;

using MassTransit;
using Requests.User;
using Services.Abstractions;

public class SearchUserConsumer(
    IUserService userService
) : IConsumer<SearchUserRequest>
{
    public async Task Consume(ConsumeContext<SearchUserRequest> context)
    {
        var response = await userService.SearchAsync(context.Message);
        await context.RespondAsync(response);
    }
}