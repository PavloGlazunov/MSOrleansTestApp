using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Order.Ports;

namespace Order.Infrastructure;

public class OrderRepository : IOrderRepository
{
    private readonly IMongoCollection<Domain.Order> _orders;
    private const string CollectionName = "orders";

    public OrderRepository(IOptions<MongoDbOptions> mongoDbOptions)
    {
        var client = new MongoClient(mongoDbOptions.Value.ConnectionString);
        var database = client.GetDatabase(mongoDbOptions.Value.DatabaseName);
        _orders = database.GetCollection<Domain.Order>(CollectionName);
    }

    public async Task<Domain.Order> FindById(Guid id)
    {
        var cursor = _orders.Find(order => order.Id == id);
        return await cursor.FirstAsync();
    }

    public async Task<List<Domain.Order>> FindAll()
    {
       return await _orders.AsQueryable().ToListAsync();
    }

    public async Task Add(Domain.Order order)
    {
        await _orders.InsertOneAsync(order);
    }

    public async Task Remove(Guid id)
    {
        await _orders.DeleteOneAsync(order => order.Id == id);
    }
}