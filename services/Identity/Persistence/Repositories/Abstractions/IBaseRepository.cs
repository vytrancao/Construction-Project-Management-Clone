namespace Persistence.Repositories.Abstractions;

public interface IBaseRepository<T>
{
    IQueryable<T> Get();
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task SaveChangesAsync();
}