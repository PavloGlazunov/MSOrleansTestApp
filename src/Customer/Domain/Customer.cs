using Core;

namespace Customer.Domain;

public class Customer : IAggregateRoot
{
    public Guid Id { get; }
    public string Email { get; private set; }
    
    public Customer(Guid id, string email)
    {
        Id = id;
        Email = email;
    }
}