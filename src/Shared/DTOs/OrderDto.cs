namespace Shared.DTOs;

public record OrderDto(List<ProductDto> Items, Guid CustomerId);