using GraphQL.Types;
using GraphQLTest.Models;

namespace GraphQLTest.GraphQL
{
    public class LineItemType : ObjectGraphType<LineItemDto>
    {
        public LineItemType()
        {
            Name = "LineItem";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("ID of the line item");
            Field(x => x.ItemId).Description("Id of the item sold");
            Field(x => x.Quantity).Description("Number of items purchased");
        }
    }
}
