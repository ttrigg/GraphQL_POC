using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphQLFoundation.Domain.Company
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public ICollection<LineItem> LineItems { get; set; }
    }
}
