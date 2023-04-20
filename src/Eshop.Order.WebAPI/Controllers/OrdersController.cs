using MediatR;
using Microsoft.AspNetCore.Mvc;
using Eshop.Order.Application.Commands;
using Eshop.Order.Application.Queries;
using Eshop.Shared.DTOs;

namespace Eshop.Order.WebAPI.Controllers;

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

    [HttpGet]
    public async Task<IList<OrderDto>> GetAll()
    {
        var query = new GetOrdersQuery();
        return await _mediator.Send(query);
    }
}