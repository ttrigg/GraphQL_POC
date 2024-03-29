﻿using HotChocolateTest.Models;
using System.Linq;
using System.Threading.Tasks;

namespace HotChocolateTest.Services.Company
{
    public interface ICompany
    {
        IQueryable<CustomerDto> GetAllCustomers();
        IQueryable<ItemDto> GetAllInventoryItems();
        IQueryable<OrderDto> GetAllOrders();
        Task<CustomerDto> GetCustomerById(int id);
        Task<OrderDto> GetOrderById(int id);
        Task<ItemDto> GetInventoryItemById(int id);
    }
}
