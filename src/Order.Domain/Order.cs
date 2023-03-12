using Core;

namespace Order.Domain;

public class Order : BaseAggregate
{
    private readonly HashSet<OrderItem> Items = new();

    public Guid CustomerId { get; private set; }
    
    public Order(Customer.Domain.Customer customer) : base(Guid.NewGuid())
    {
        CustomerId = customer.Id;
    }

    public void Add(Product.Domain.Product product)
    {
        Items.Add(new OrderItem(Id, product.Id, product.Price));
    }
}