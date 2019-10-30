using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphQLFoundation.Domain.Company
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
