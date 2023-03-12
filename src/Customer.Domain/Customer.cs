using Core;

namespace Customer.Domain;

public class Customer : BaseAggregate
{
    public string Email { get; private set; }
    
    public Customer(string email) : base(Guid.NewGuid())
    {
        Email = email;
    }
}