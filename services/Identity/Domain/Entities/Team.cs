namespace Domain.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Team
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; init; }
    public required string Name { get; set; }
    public required bool IsStandalone { get; set; }
    public required DateTime CreatedAt { get; set; }

    public IEnumerable<User> Members { get; set; }
}