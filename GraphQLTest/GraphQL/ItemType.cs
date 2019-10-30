using GraphQL.Types;
using GraphQLFoundation.Models;

namespace GraphQLTest.GraphQL
{
    public class ItemType : ObjectGraphType<ItemDto>
    {
        public ItemType()
        {
            Name = "Item";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("ID of the item");
            Field(x => x.Name).Description("Name of the item");
            Field(x => x.SKU).Description("SKU of the item");
            Field(x => x.Count).Description("Count of the item");
        }
    }
}
