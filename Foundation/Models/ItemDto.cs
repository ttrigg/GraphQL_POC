using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GraphQLFoundation.Models
{
    [DataContract]
    public class ItemDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SKU { get; set; }
        [DataMember]
        public int Count { get; set; }
    }
}
