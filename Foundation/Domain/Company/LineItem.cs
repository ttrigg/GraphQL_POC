using System.ComponentModel.DataAnnotations;

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
