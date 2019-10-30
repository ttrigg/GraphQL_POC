using GraphQL.Types;
using GraphQLFoundation.Models;

namespace GraphQLTest.GraphQL
{
    public class OrderType : ObjectGraphType<OrderDto>
    {
        public OrderType()
        {
            Name = "Order";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("ID of the item");
            Field(x => x.OrderDate).Description("Date and time of the order");
            Field(x => x.Taxes).Description("SKU of the item");
            Field(x => x.LineItems, type: typeof(ListGraphType<LineItemType>)).Description("Order line items");
        }
    }
}
