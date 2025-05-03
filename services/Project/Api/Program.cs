using Api;
using Cpm.Common.Messages;
using Rebus.Config;
using Rebus.Routing.TypeBased;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.AddControllers();
builder.Services.AddOpenApi();

// var queueName = "prj";
// services.AddRebus(
//     configure => configure
//         .Transport(x => x.UseRabbitMq("amqp://guest:guest@localhost:3001", queueName)),
//     // .Routing(x => x.TypeBased().MapAssemblyOf<BaseMessage>(queueName)),
//     onCreated: async bus => await bus.Subscribe<HelloWorld>()
// );
// services.AutoRegisterHandlersFromAssembly(nameof(Api));

var app = builder.Build();

app.MapOpenApi();

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

await app.RunAsync();