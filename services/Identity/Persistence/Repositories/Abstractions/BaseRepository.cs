namespace Persistence.Repositories.Abstractions;

using Microsoft.EntityFrameworkCore;

public abstract class BaseRepository<T>(DbContext dbContext) : IBaseRepository<T> where T : class
{
    private DbContext DbContext { get; } = dbContext;

    public virtual IQueryable<T> Get()
    {
        return DbContext.Set<T>().AsQueryable();
    }

    public virtual void Create(T entity)
    {
        DbContext.Set<T>().Add(entity);
    }

    public virtual void Update(T entity)
    {
        DbContext.Set<T>().Update(entity);
    }

    public virtual void Delete(T entity)
    {
        DbContext.Set<T>().Remove(entity);
    }

    public async Task SaveChangesAsync()
    {
        await DbContext.SaveChangesAsync();
    }
}