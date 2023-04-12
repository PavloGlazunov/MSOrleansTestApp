namespace Shared.DTOs;

public class OrderDto
{
    public IList<ProductDto> Items { get; set; }
    public Guid CustomerId { get; set; }
}