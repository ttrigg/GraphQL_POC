using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HotChocolateTest.Models
{
    [DataContract]
    public class LineItemDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int ItemId { get; set; }
        [DataMember]
        public int Quantity { get; set; }
    }
}
