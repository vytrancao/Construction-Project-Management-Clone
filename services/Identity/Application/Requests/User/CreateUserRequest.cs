namespace Application.Requests.User;

using Domain.Enums;
using MassTransit;

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
}