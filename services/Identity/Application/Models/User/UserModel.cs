namespace Application.Models.User;

using Domain.Enums;

public record UserModel(
    Guid Id,
    string Email,
    string FirstName,
    string LastName,
    UserRole Role,
    Guid? IdentityUserId
);