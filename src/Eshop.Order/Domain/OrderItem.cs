using Eshop.Core;
using Eshop.Shared.Domain;

namespace Eshop.Order.Domain;

public class OrderItem : IEntity
{
    public Guid Id { get; }
    public Guid OrderId { get; private set; }
    
    public Guid ProductId { get; private set; }
    
    public Money Price { get; private set; }

    public OrderItem(Guid id, Guid orderId, Guid productId, Money price)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }
}