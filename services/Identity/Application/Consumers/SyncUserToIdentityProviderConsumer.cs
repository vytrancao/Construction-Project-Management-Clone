namespace Application.Consumers;

using AutoMapper;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Requests.User;
using Services.Abstractions;

public class SyncUserToIdentityProviderConsumer(
    IUserService userService,
    IIdentityProvider identityProvider,
    IConfiguration configuration,
    IMapper mapper,
    ILogger<SyncUserToIdentityProviderConsumer> logger) : IConsumer<SyncUserToIdentityProviderRequest>
{
    public async Task Consume(ConsumeContext<SyncUserToIdentityProviderRequest> context)
    {
        var usersToSync = userService.GetSyncToIdentityProvider();

        logger.LogInformation("Syncing {Count} users to identity provider", usersToSync.Count());
        foreach (var user in usersToSync)
        {
            var request = mapper.Map<CreateUserRequest>(user);
            request.Password = configuration["Keycloak:DefaultPassword"];

            var registerResponse = await identityProvider.RegisterUser(request);
            user.IdentityUserId = registerResponse.Id;
        }

        await userService.UpdateRangeAsync(usersToSync);
    }
}