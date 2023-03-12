using Core;
using Shared.Domain;

namespace Order.Domain;

public class OrderItem : BaseEntity
{
    public Guid OrderId { get; private set; }
    
    public Guid ProductId { get; private set; }
    
    public Money Price { get; private set; }

    public OrderItem(Guid orderId, Guid productId, Money price) : base(Guid.NewGuid())
    {
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }
}