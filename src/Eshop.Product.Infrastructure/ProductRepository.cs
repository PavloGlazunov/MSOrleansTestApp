using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Eshop.Product.Ports;
using Eshop.Shared;

namespace Eshop.Product.Infrastructure;

public class ProductRepository : IProductRepository
{
    private readonly IMongoCollection<Domain.Product> _products;
    private const string CollectionName = "products";

    public ProductRepository(IOptions<MongoDbOptions> mongoDbOptions)
    {
        var client = new MongoClient(mongoDbOptions.Value.ConnectionString);
        var database = client.GetDatabase(mongoDbOptions.Value.DatabaseName);
        _products = database.GetCollection<Domain.Product>(CollectionName);
    }

    public async Task<Domain.Product> FindById(Guid id)
    {
        var cursor = _products.Find(order => order.Id == id);
        return await cursor.FirstAsync();
    }

    public async Task<IList<Domain.Product>> FindAll()
    {
       return await _products.AsQueryable().ToListAsync();
    }

    public async Task Add(Domain.Product order)
    {
        await _products.InsertOneAsync(order);
    }

    public async Task Remove(Guid id)
    {
        await _products.DeleteOneAsync(order => order.Id == id);
    }
}