using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using GraphQLFoundation.Domain.Company;
using GraphQLFoundation.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLFoundation.Services.Company
{
    public class Company : ICompany
    {
        private readonly CompanyDBContext _companyDBContext;
        private readonly IConfigurationProvider _configurationProvider;

        public Company(CompanyDBContext companyDBContext, IConfigurationProvider configurationProvider)
        {
            _companyDBContext = companyDBContext;
            _configurationProvider = configurationProvider;
        }

        #region Customers

        public IQueryable<CustomerDto> GetAllCustomers() =>
            _companyDBContext.Customers
                .Include("Orders")
                .Include("LineItems")
                .ProjectTo<CustomerDto>(_configurationProvider);

        public async Task<CustomerDto> GetCustomerById(int id) =>
            await GetAllCustomers()
                .FirstOrDefaultAsync(x => x.Id == id);

        #endregion

        #region Inventory
        public IQueryable<ItemDto> GetAllInventoryItems() =>
            _companyDBContext.Items
                .ProjectTo<ItemDto>(_configurationProvider);

        public async Task<ItemDto> GetInventoryItemById(int id) =>
            await GetAllInventoryItems()
                .FirstOrDefaultAsync(x => x.Id == id);

        #endregion

        #region Orders
        
        public IQueryable<OrderDto> GetAllOrders() =>
            _companyDBContext.Orders
                .ProjectTo<OrderDto>(_configurationProvider);

        public async Task<OrderDto> GetOrderById(int id) =>
            await GetAllOrders()
                .FirstOrDefaultAsync(x => x.Id == id);

        #endregion

    }
}
