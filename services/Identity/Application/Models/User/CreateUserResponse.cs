namespace Application.Models.User;

using Domain.Entities;
using Domain.Enums;

public record CreateUserResponse(
    Guid Id,
    string Email,
    string FirstName,
    string LastName,
    UserRole Role,
    Guid? IdentityUserId
)
{
    public Uri? CreatedUri { get; set; }

    public static CreateUserResponse FromEntity(User user)
        => new(
            Id: user.Id,
            Email: user.Email,
            FirstName: user.FirstName,
            LastName: user.LastName,
            Role: user.Role!,
            IdentityUserId: user.IdentityUserId
        );
}