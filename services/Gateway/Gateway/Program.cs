using Keycloak.AuthServices.Authentication;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile(
    $"ocelot.{builder.Environment.EnvironmentName}.json",
    optional: false,
    reloadOnChange: true
);

builder.Services.AddKeycloakWebApiAuthentication(builder.Configuration);
builder.Services.AddAuthorization();

builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapOpenApi();
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("http://estore.api/product/openapi.json", "Product");
        options.SwaggerEndpoint("http://estore.api/order/openapi.json", "Order");
        options.SwaggerEndpoint("http://estore.api/inventory/openapi.json", "Inventory");
        options.RoutePrefix = string.Empty;
    });
}

app.UseAuthentication();
app.UseAuthorization();

await app.UseOcelot();
await app.RunAsync();