namespace Application.Requests.User;

using Domain.Constants;
using Domain.Entities;
using Domain.Enums;
using Keycloak.AuthServices.Sdk.Admin.Models;

public record CreateUserRequest(
    string Email,
    string FirstName,
    string LastName,
    UserRole Role,
    string Password
)
{
    public string Password { get; set; } = Password;
    public Guid? Id { get; set; }

    public CreateUserRequest() : this("", "", "", UserRole.Client, "")
    {
    }

    public User ToEntity()
        => new()
        {
            Email = Email,
            FirstName = FirstName,
            LastName = LastName,
            Role = Role
        };

    public UserRepresentation ToIdentityRepresentation()
        => new()
        {
            Email = Email,
            FirstName = FirstName,
            LastName = LastName,
            Username = Email,
            Enabled = true,
            Credentials = new List<CredentialRepresentation>
            {
                new()
                {
                    Type = CredentialType.Password,
                    Value = Password,
                    Temporary = false
                }
            }
        };

    public static CreateUserRequest FromEntity(User user)
        => new(
            Email: user.Email,
            FirstName: user.FirstName,
            LastName: user.LastName,
            Role: user.Role,
            Password: string.Empty
        );
}