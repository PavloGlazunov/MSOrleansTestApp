using MediatR;
using Eshop.Shared.DTOs;

namespace Eshop.Order.Application.Queries
{
    public class GetOrdersQuery : IRequest<IList<OrderDto>>
    {
    }
}
