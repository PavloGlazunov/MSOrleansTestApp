namespace Shared.DTOs;

using Domain;

public class ProductDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Money Price { get; set; }
}