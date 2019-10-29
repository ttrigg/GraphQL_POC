using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest.AutoMapper
{
    public class AutoMapperMaps : Profile
    {
        public AutoMapperMaps()
        {
            CreateMap<Domain.Company.Customer, Models.CustomerDto>();
            CreateMap<Domain.Company.Item, Models.ItemDto>();
            CreateMap<Domain.Company.Order, Models.OrderDto>();
            CreateMap<Domain.Company.LineItem, Models.LineItemDto>();
        }
    }
}
