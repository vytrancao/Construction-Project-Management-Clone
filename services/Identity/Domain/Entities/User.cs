namespace Domain.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Enums;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; init; }

    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public UserRole Role { get; set; }
    public Guid? IdentityUserId { get; set; }
}