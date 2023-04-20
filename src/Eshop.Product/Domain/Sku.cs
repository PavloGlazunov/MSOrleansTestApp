namespace Eshop.Product.Domain;

public record Sku
{
    public string Value { get; init; }

    private Sku(string value) => Value = value; 

    public static Sku? Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return new Sku(value);
    }
}