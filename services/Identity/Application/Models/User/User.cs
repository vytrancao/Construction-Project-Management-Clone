namespace Application.Models.User;

using global::Keycloak.AuthServices.Sdk.Admin.Models;

public class User : UserRepresentation
{
    [System.Text.Json.Serialization.JsonPropertyName("clientIds")]
    public List<string> ClientIds { get; set; }
}