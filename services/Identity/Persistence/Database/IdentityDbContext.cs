namespace Persistence.Database;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class IdentityDbContext(DbContextOptions options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Team> Teams { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        new DbSeeder(builder).Seed();
    }
}