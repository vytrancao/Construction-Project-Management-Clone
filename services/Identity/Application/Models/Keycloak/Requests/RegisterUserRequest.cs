namespace Application.Models.Keycloak.Requests;

using global::Keycloak.AuthServices.Sdk.Admin.Models;

public class RegisterUserRequest : UserRepresentation
{
    public string Username { get; set; }
    public string Email { get; set; }
    public bool Enabled { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IEnumerable<Credential> Credentials { get; set; }
}