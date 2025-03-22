namespace Application.Extensions;

using AutoMapper;
using Consumers;
using Contracts.User;
using MapProfiles;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Abstractions;
using DependencyInjectionRegistrationExtensions = MassTransit.DependencyInjectionRegistrationExtensions;
using InMemoryConfigurationExtensions = MassTransit.InMemoryConfigurationExtensions;
using InMemorySagaRepositoryRegistrationExtensions = MassTransit.InMemorySagaRepositoryRegistrationExtensions;
using RegistrationExtensions = MassTransit.RegistrationExtensions;

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
                rider.AddProducer<UserCreateRequest>("topic-name");
                rider.AddConsumer<KafkaMessageConsumer>();

                rider.UsingKafka((context, k) =>
                {
                    k.Host($"{host}:{port}");

                    k.TopicEndpoint<UserCreateRequest>("topic-name", "consumer-group-name",
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
        services.AddMediator(cfg => { cfg.AddConsumer<CreateUserConsumer>(); });
    }

    public static void AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();

        services.AddScoped<IIdentityProvider, KeycloakProvider>();
    }
}