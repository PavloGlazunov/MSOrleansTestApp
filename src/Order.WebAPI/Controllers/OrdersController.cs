using MediatR;
using Microsoft.AspNetCore.Mvc;
using Order.Application.Commands;
using Shared.DTOs;

namespace Order.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    private readonly ILogger<OrdersController> _logger;

    private readonly IMediator _mediator;

    public OrdersController(ILogger<OrdersController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task CreateOrder(OrderDto order)
    {
        var orderCreateCmd = new CreateOrderCommand(order);
        await _mediator.Send(orderCreateCmd);
    }
}