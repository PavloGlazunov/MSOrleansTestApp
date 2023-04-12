using AutoMapper;
using Shared.DTOs;

namespace Order.Application
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
