namespace Application.Consumers;

using Requests.User;
using MassTransit;
using Microsoft.Extensions.Logging;
using Serilog;

internal class KafkaMessageConsumer(ILogger<KafkaMessageConsumer> logger) : IConsumer<CreateUserRequest>
{
    public Task Consume(ConsumeContext<CreateUserRequest> context)
    {
        logger.LogError("Hello from Kafka!");
        return Task.CompletedTask;
    }
}