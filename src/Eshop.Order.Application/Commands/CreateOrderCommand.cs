using Eshop.Core.Domain;
using Eshop.Shared.DTOs;

namespace Eshop.Order.Application.Commands;

public record CreateOrderCommand(OrderDto Order) : ICommand;