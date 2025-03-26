using Api.Extensions;
using Application.Extensions;
using Persistence.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
configuration.AddEnvironmentVariables();

var isDevelopment = builder.Environment.IsDevelopment();
if (!isDevelopment)
{
    Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).CreateLogger();
    services.AddSerilog();
}

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

if (isDevelopment)
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint($"openapi/v1.json", "Identity");
        options.RoutePrefix = "";
    });
}

app.UseRouting();
app.UseAuthorization();
app.MapControllers();
if (!isDevelopment)
    app.UseSerilogRequestLogging();

await app.RunAsync();