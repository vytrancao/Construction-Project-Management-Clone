namespace Application.Requests.User;

using Bogus.DataSets;
using Domain.Constants;
using Domain.Entities;
using Domain.Enums;
using Keycloak.AuthServices.Sdk.Admin.Models;

public record CreateUserRequest(
    string Email,
    string FirstName,
    string LastName,
    UserRole Role,
    string Password,
    string Phone,
    string Address
)
{
    public string Password { get; set; } = Password;
    public Guid? Id { get; set; }

    public CreateUserRequest()
        : this(
            Email: string.Empty,
            FirstName: string.Empty,
            LastName: string.Empty,
            Role: UserRole.Employee,
            Password: string.Empty,
            Phone: string.Empty,
            Address: string.Empty
        )
    {
    }

    public User ToEntity()
        => new()
        {
            Email = Email,
            FirstName = FirstName,
            LastName = LastName,
            Role = Role,
            Phone = Phone,
            Address = Address,
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
            Password: string.Empty,
            Phone: user.Phone,
            Address: user.Address
        );
}