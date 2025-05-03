namespace Application.Messaging;

using Cpm.Common.Messages.Identity;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Rebus.Handlers;
using Requests.User;
using Services.Abstractions;

public class SyncIdentityUserHandler(
    IUserService userService,
    IIdentityProvider identityProvider,
    ILogger<SyncIdentityUserHandler> logger,
    IConfiguration configuration
) : IHandleMessages<SyncIdentityUser>
{
    private readonly string _defaultPassword = configuration["Keycloak:DefaultPassword"]!;

    public async Task Handle(SyncIdentityUser message)
    {
        var usersToSync = userService.GetSyncToIdentityProvider();

        logger.LogInformation("Syncing {Count} users to identity provider", usersToSync.Count());

        await Task.WhenAll(usersToSync.Select(SyncIdentityUser));
        await userService.UpdateRangeAsync(usersToSync);
    }

    private async Task SyncIdentityUser(User user)
    {
        var request = CreateUserRequest.FromEntity(user);
        request.Password = _defaultPassword;

        var registerResponse = await identityProvider.RegisterUser(request);
        user.IdentityUserId = registerResponse.Id;
    }
}