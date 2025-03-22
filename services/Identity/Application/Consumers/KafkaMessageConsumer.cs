namespace Application.Consumers;

using Contracts.User;
using MassTransit;
using Microsoft.Extensions.Logging;

internal class KafkaMessageConsumer(ILogger<KafkaMessageConsumer> logger) : IConsumer<UserCreateRequest>
{
    public Task Consume(ConsumeContext<UserCreateRequest> context)
    {
        Console.Write("Hello from Kafka!");
        return Task.CompletedTask;
    }
}