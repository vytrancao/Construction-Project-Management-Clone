namespace Application.Extensions;

using Cpm.Common.Messages;
using Cpm.Common.Messages.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rebus.Config;
using Rebus.Routing.TypeBased;
using Services;
using Services.Abstractions;

public static class Startup
{
    public static void AddMessaging(this IServiceCollection services, IConfiguration configuration)
    {
        var queueName = configuration["ServiceName"];
        var host = configuration["Messaging:Host"];
        services.AddRebus(
            configure => configure
                .Transport(x => x.UseRabbitMq(host, queueName))
                .Routing(x => x.TypeBased().MapAssemblyOf<BaseMessage>(queueName)),
            onCreated: async bus =>
            {
                await bus.Subscribe<HelloWorld>();
                await bus.Subscribe<SyncIdentityUser>();
            });
        services.AutoRegisterHandlersFromAssembly(nameof(Application));
    }

    public static void AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();

        services.AddScoped<IIdentityProvider, KeycloakProvider>();
    }
}