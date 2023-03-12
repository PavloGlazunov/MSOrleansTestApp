namespace Core;

public abstract class BaseAggregate
{
    public Guid Id { get; private set; }
    
    public BaseAggregate(Guid id)
    {
        Id = id;
    }
}