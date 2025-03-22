namespace Persistence.Extensions;

using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Repositories.Abstractions;

public static class Startup
{
    public static void AddPersistent(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
    }
}