using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GraphQLFoundation.Models
{
    [DataContract]
    public class OrderDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public decimal Taxes { get; set; }
        [DataMember]
        public decimal Total { get; set; }
        [DataMember]
        public ICollection<LineItemDto> LineItems { get; set; }
    }
}
