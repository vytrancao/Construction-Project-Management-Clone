using Api.Extensions;
using Domain.Enums;
using Keycloak.AuthServices.Authentication;
using Keycloak.AuthServices.Authorization;
using Keycloak.AuthServices.Common;
using Keycloak.AuthServices.Sdk;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddKeycloakWebApi(builder.Configuration);
// builder.Services.AddAuthorization()
//     .AddKeycloakAuthorization()
//     .AddAuthorizationBuilder()
//     .AddPolicy(
//         nameof(UserRoles.Admin),
//         policy => policy.RequireResourceRolesForClient("security-admin-console", [nameof(UserRoles.Employee)])
//     )
//     .AddPolicy(
//         nameof(UserRoles.Employee),
//         policy => policy.RequireRealmRoles(nameof(UserRoles.Employee))
//     )
//     .AddPolicy(
//         nameof(UserRoles.Client),
//         policy => policy.RequireRealmRoles(nameof(UserRoles.Client))
//     );
builder.Services
    .AddAuthorization()
    .AddKeycloakAuthorization(options =>
    {
        options.EnableRolesMapping =
            RolesClaimTransformationSource.ResourceAccess;
        options.RolesResource = "security-admin-console";
    })
    .AddAuthorizationBuilder()
    .AddPolicy(
        nameof(UserRoles.Admin),
        policy => policy.RequireRole(nameof(UserRoles.Admin))
    );

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddRedisCache();

builder.Services.AddDistributedMemoryCache();
var options = builder.Configuration.GetKeycloakOptions<KeycloakAdminClientOptions>()!;
builder.Services
    .AddClientCredentialsTokenManagement()
    .AddClient(
        "keycloak.client",
        client =>
        {
            client.ClientId = options.Resource;
            client.ClientSecret = options.Credentials.Secret;
            client.TokenEndpoint = options.KeycloakTokenEndpoint;
        }
    );
builder.Services.AddKeycloakAdminHttpClient(builder.Configuration)
    .AddClientCredentialsTokenHandler("keycloak.client");

var app = builder.Build();

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