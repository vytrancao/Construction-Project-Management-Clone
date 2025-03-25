namespace Persistence.Database;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class IdentityDbContext(DbContextOptions options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        new DbSeeder(builder).Seed();
    }
}