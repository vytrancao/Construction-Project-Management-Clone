namespace Application.Extensions;

using AutoMapper;
using Requests.User;
using Consumers;
using MapProfiles;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Abstractions;

public static class Startup
{
    public static void AddMapper(this IServiceCollection services)
    {
        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new KeycloakUserProfile());
            mc.AddProfile(new UserMapperProfile());
        });
        var mapper = mappingConfig.CreateMapper();
        services.AddSingleton(mapper);
    }

    public static void AddMessaging(this IServiceCollection services, IConfiguration configuration)
    {
        var host = configuration["Messaging:Host"];
        var port = configuration["Messaging:Port"];
        services.AddMassTransit(x =>
        {
            x.UsingInMemory();
            x.SetKebabCaseEndpointNameFormatter();
            x.SetInMemorySagaRepositoryProvider();

            x.AddRider(rider =>
            {
                rider.AddProducer<CreateUserRequest>("topic-name");
                rider.AddConsumer<KafkaMessageConsumer>();

                rider.UsingKafka((context, k) =>
                {
                    k.Host($"{host}:{port}");

                    k.TopicEndpoint<CreateUserRequest>("topic-name", "consumer-group-name",
                        e =>
                        {
                            e.ConfigureConsumer<KafkaMessageConsumer>(context);
                            e.CreateIfMissing();
                        });
                });
            });
        });
    }

    public static void AddMediators(this IServiceCollection services)
    {
        services.AddMediator(cfg =>
        {
            cfg.AddConsumer<CreateUserConsumer>();
            cfg.AddConsumer<SyncUserToIdentityProviderConsumer>();
            cfg.AddConsumer<SearchUserConsumer>();
        });
    }

    public static void AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();

        services.AddScoped<IIdentityProvider, KeycloakProvider>();
    }
}