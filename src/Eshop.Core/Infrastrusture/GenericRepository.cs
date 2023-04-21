using Eshop.Core.Domain;
using Eshop.Shared;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Eshop.Core.Infrastrusture
{
    public class GenericRepository<TEntity> : IRepository<TEntity>
            where TEntity : class, IEntity
    {
        private readonly IMongoCollection<TEntity> _entities;
        public GenericRepository(IOptions<MongoDbOptions> mongoDbOptions)
        {
            var client = new MongoClient(mongoDbOptions.Value.ConnectionString);
            var database = client.GetDatabase(mongoDbOptions.Value.DatabaseName);
            _entities = database.GetCollection<TEntity>($"{typeof(TEntity).Name}Collection");
        }
        public async Task<TEntity> FindById(Guid id)
        {
            var cursor = _entities.Find(entity => entity.Id == id);
            return await cursor.FirstAsync();
        }

        public async Task<IList<TEntity>> FindAll()
        {
            return await _entities.AsQueryable().ToListAsync();
        }

        public async Task Add(TEntity entity)
        {
            await _entities.InsertOneAsync(entity);
        }

        public async Task Remove(Guid id)
        {
            await _entities.DeleteOneAsync(entity => entity.Id == id);
        }
    }
}
