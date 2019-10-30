using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
