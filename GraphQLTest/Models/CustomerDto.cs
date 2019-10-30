using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GraphQLTest.Models
{
    [DataContract]
    public class CustomerDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public ICollection<OrderDto> Orders { get; set; }
    }
}
