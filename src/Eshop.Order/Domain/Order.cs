using Eshop.Core.Domain;

namespace Eshop.Order.Domain;

public class Order : IAggregateRoot
{
    public Guid Id { get; }
    
    private readonly HashSet<OrderItem> Items = new();

    public Guid CustomerId { get; private set; }
    
    public Order(Customer.Domain.Customer customer)
    {
        Id = Guid.NewGuid();
        CustomerId = customer.Id;
    }

    public void Add(Product.Domain.Product product)
    {
        Items.Add(new OrderItem(Guid.NewGuid(), Id, product.Id, product.Price));
    }

}