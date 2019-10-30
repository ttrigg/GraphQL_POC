using System.ComponentModel.DataAnnotations;

namespace GraphQLFoundation.Domain.Company
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public int Count { get; set; }
    }
}
