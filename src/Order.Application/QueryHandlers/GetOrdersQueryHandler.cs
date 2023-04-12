using AutoMapper;
using MediatR;
using Order.Application.Queries;
using Order.Ports;
using Shared.DTOs;


namespace Order.Application.QueryHandlers
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, IList<OrderDto>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrdersQueryHandler(IOrderRepository orderRepository, IMapper mapper)
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
