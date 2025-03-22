using Api.Extensions;
using Application.Extensions;
using Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
configuration.AddEnvironmentVariables();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

services.AddControllers();
services.AddOpenApi();
services.AddDbContext(configuration);

// Keycloak
services.AddKeycloakAuthenticationAndAuthorization(configuration);
services.AddKeycloakAdminClient(configuration);

// Services
services.AddMapper();
services.AddAppServices();
services.AddMessaging(configuration);
services.AddMediators();
services.AddLogging();

// Persistent
services.AddPersistent();

var app = builder.Build();

app.UpdateDatabase();

app.MapOpenApi();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint($"{Environment.GetEnvironmentVariable("BASE_API_URL")}/identity/openapi/v1.json", "Identity");
    options.RoutePrefix = "identity";
});

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

await app.RunAsync();