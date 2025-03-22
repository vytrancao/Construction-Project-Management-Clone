namespace Application.Contracts.User;

using System.ComponentModel.DataAnnotations;
using Domain.Enums;

public record UserCreateRequest(
    string Email,
    string FirstName,
    string LastName,
    UserRole Role,
    string Password
)
{
    public Guid? Id { get; set; }
}