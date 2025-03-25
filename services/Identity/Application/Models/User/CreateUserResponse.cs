namespace Application.Models.User;

using Domain.Enums;

public record CreateUserResponse(
    Guid Id,
    string Email,
    string FirstName,
    string LastName,
    UserRole Role,
    Guid IdentityUserId
)
{
    public Uri CreatedUri { get; set; }
}