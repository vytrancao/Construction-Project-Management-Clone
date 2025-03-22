namespace Persistence.Repositories;

using Abstractions;
using Database;
using Domain.Entities;

public class UserRepository(IdentityDbContext _dbContext) : BaseRepository<User>(_dbContext), IUserRepository
{
}