namespace Shared.DTOs;

using Domain;

public record ProductDto(Guid Id, string Name, Money Price);