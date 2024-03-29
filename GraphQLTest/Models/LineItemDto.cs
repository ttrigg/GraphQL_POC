﻿using System.Runtime.Serialization;

namespace GraphQLTest.Models
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
