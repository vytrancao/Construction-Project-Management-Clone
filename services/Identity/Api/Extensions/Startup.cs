namespace Api.Extensions;

using StackExchange.Redis;

public static class Startup
{
    public static void AddRedisCache(this IServiceCollection services)
    {
        services.AddScoped<IServer>(cfg =>
        {
            var multiplexer = ConnectionMultiplexer.Connect(Environment.GetEnvironmentVariable("cache")!);
            return multiplexer.GetServer("cache", 6379);
        });
    }
}