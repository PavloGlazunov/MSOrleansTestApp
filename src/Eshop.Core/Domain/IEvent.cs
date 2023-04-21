namespace Eshop.Core.Domain;

public interface IEvent
{
    Guid Id { get; set; }
    int Version { get; set; }
}