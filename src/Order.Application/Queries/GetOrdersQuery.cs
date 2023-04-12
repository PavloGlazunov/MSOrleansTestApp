using MediatR;
using Shared.DTOs;

namespace Order.Application.Queries
{
    public class GetOrdersQuery : IRequest<IList<OrderDto>>
    {
    }
}
