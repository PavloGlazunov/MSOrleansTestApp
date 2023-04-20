using AutoMapper;
using Eshop.Shared.DTOs;

namespace Eshop.Order.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<Domain.Order, OrderDto>();
            CreateMap<OrderDto, Domain.Order>();
        }
    }
}
