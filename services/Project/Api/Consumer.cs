namespace Api;

using Cpm.Common.Messages;
using Rebus.Handlers;

public class Consumer(
    ILogger<Consumer> logger) : IHandleMessages<HelloWorld>
{
    public async Task Handle(HelloWorld message)
    {
        logger.LogInformation($"Received message {message.GetType().Name}");
    }
}