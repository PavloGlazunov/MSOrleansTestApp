namespace Eshop.Core;

public interface IRepository<TEntity>
{
    Task<TEntity> FindById(Guid id);
    Task<IList<TEntity>> FindAll();
    Task Add(TEntity order);
    Task Remove(Guid id);
}