using MediatR;
using Eshop.Order.Application.Commands;
using Eshop.Core.Infrastrusture;

namespace Eshop.Order.Application.CommandHandlers;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
{
    private readonly IRepository<Domain.Order> _orderRepository;

    public CreateOrderCommandHandler(IRepository<Domain.Order> orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var customer = new Customer.Domain.Customer(request.Order.CustomerId, "test@foo.bar");
        var order = new Domain.Order(customer);
        foreach (var item in request.Order.Items)
        {
            order.Add(new Product.Domain.Product(item.Id, item.Name, item.Price, null));
        }
        await _orderRepository.Add(order);
    }
}