using Api.Extensions;
using Keycloak.AuthServices.Authentication;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddKeycloakWebApiAuthentication(builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddRedisCache();
builder.Services.AddRefitClients();

var app = builder.Build();

app.MapOpenApi();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint($"{Environment.GetEnvironmentVariable("BASE_API_URL")}/identity/openapi/v1.json", "Identity");
    options.RoutePrefix = "identity";
});

app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

await app.RunAsync();