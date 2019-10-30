using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLFoundation.Domain.Company
{
    public class LineItem
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
    }
}
