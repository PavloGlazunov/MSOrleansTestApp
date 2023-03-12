using MediatR;
using Order.CQRS.Commands;

namespace Order.CQRS.CommandHandlers;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Domain.Order>
{
    public Task<Domain.Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}