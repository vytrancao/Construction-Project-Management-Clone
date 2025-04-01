namespace Persistence.Database;

using Bogus;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

public class DbSeeder(ModelBuilder modelBuilder)
{
    public void Seed()
    {
        var userFaker = new Faker<User>().UseSeed(121002)
            .RuleFor(u => u.Id, f => f.Random.Guid())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Role, f => f.PickRandom<UserRole>());

        modelBuilder.Entity<User>().HasData(userFaker.Generate(200));
    }
}