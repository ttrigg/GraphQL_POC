using AutoMapper;
using GraphQLFoundation.Domain.Company;

namespace GraphQLTest.AutoMapper
{
    public class AutoMapperMaps : Profile
    {
        public AutoMapperMaps()
        {
            CreateMap<Customer, Models.CustomerDto>();
            CreateMap<Item, Models.ItemDto>();
            CreateMap<Order, Models.OrderDto>();
            CreateMap<LineItem, Models.LineItemDto>();
        }
    }
}
