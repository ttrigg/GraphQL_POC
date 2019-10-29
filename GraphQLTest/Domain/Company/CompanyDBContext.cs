using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest.Domain.Company
{
    public class CompanyDBContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }

        public CompanyDBContext(DbContextOptions<CompanyDBContext> options)
            : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var rnd = new Random();
            int id = 1;

            // add-migration "Initial" -Context GraphQLTest.Domain.Company.CompanyDBContext
            // update-database -Context GraphQLTest.Domain.Company.CompanyDBContext

            #region Fill junk data

            // Inventory
            modelBuilder.Entity<Item>().HasData(
                Enumerable.Range(0, 50)
                .Select(x => new Item()
                {
                    Id = id++,
                    Name = Guid.NewGuid().ToString(),
                    SKU = Guid.NewGuid().ToString(),
                    Count = rnd.Next(0, 2000)
                })
                .ToArray());

            // Customer
            id = 1;
            modelBuilder.Entity<Customer>().HasData(Enumerable.Range(0, 500)
                .Select(x => new Customer()
                {
                    Id = id++,
                    FirstName = Guid.NewGuid().ToString(),
                    LastName = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(1970, 1, 1).AddDays(rnd.Next(11322)) // number of days from 1/1/1970 - 12/31/2000
                }).ToArray());

            // Create orders for random customer
            id = 1;
            modelBuilder.Entity<Order>().HasData(Enumerable.Range(0, 1000)
                .Select(x => new Order()
                {
                    Id = id++,
                    OrderDate = new DateTime(2019, 1, 1).AddDays(rnd.Next(300)), // number of days from 1/1/2019 - 10/28/2019
                    Taxes = 0.04m,
                    Total = (decimal)rnd.Next(0, 2500),
                    CustomerId = rnd.Next(1, 500),
                }).ToArray());

            // Create line items for order
            id = 1;
            modelBuilder.Entity<LineItem>().HasData(Enumerable.Range(0, 1000)
                .Select(o => new LineItem()
                {
                    Id = id++,
                    OrderId = rnd.Next(1, 1000),
                    ItemId = rnd.Next(1, 50),
                    Quantity = rnd.Next(1, 10)
                }).ToArray());

            #endregion

            base.OnModelCreating(modelBuilder);
        }

    }
}
