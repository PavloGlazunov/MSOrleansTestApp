using Core;
using Shared.DTOs;

namespace Order.Application.Commands;

public record CreateOrderCommand(OrderDto Order) : ICommand;