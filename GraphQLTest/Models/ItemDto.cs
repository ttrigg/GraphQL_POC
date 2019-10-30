using System.Runtime.Serialization;

namespace GraphQLTest.Models
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
