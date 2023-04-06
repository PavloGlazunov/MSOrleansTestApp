namespace Core;

public interface IRepository<TEntity>
{
    Task<TEntity> FindById(Guid id);
    Task<List<TEntity>> FindAll();
    Task Add(TEntity order);
    Task Remove(Guid id);
}