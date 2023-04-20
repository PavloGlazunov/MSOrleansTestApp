using Eshop.Core;
using Eshop.Shared.Domain;

namespace Eshop.Product.Domain;

public class Product : IAggregateRoot
{
    public Guid Id { get; }
    public string Name { get; private set; }
    
    public Money Price { get; private set; }
    
    public Sku Sku { get; private set; }
    
    public Product(Guid id, string name, Money price, string skuValue)
    {
        Id = id;
        Name = name;
        Price = price;
        Sku = Sku.Create(skuValue);
    }

}