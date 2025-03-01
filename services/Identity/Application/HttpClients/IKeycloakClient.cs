namespace Application.HttpClients;

using Models.Keycloak.Requests;
using Refit;

[Headers("accept: application/json", "Authorization: Bearer")]
public interface IKeycloakClient
{
    [Post("/users")]
    Task<HttpResponseMessage> RegisterUser([Body] RegisterUserRequest request);
}