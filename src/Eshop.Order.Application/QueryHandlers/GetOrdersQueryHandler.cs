using AutoMapper;
using MediatR;
using Eshop.Order.Application.Queries;
using Eshop.Order.Ports;
using Eshop.Shared.DTOs;
using Eshop.Core.Infrastrusture;
using Eshop.Order.Domain;

namespace Eshop.Order.Application.QueryHandlers
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, IList<OrderDto>>
    {
        private readonly IRepository<Domain.Order> _orderRepository;
        private readonly IMapper _mapper;

        public GetOrdersQueryHandler(IRepository<Domain.Order> orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<IList<OrderDto>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = await _orderRepository.FindAll();
            return _mapper.Map<IList<Domain.Order>, IList<OrderDto>>(orders);
        }
    }
}
