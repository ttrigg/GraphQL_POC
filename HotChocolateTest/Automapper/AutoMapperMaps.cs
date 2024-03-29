﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLFoundation.Domain.Company;

namespace HotChocolateTest.AutoMapper
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
