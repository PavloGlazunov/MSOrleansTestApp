using Core;

namespace Order.CQRS.Commands;

public record CreateOrderCommand(Domain.Order Order) : ICommand<Domain.Order>;