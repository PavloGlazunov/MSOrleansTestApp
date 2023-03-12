using Core;
using Shared.Domain;

namespace Product.Domain;

public class Product : BaseAggregate
{
    public string Name { get; private set; }
    
    public Money Price { get; private set; }
    
    public Sku Sku { get; private set; }
    
    public Product(string name, Money price, string skuValue) : base(Guid.NewGuid())
    {
        Name = name;
        Price = price;
        Sku = Sku.Create(skuValue);
    }
}