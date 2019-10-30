using GraphQL.Types;
using GraphQLTest.Models;

namespace GraphQLTest.GraphQL
{
    public class CustomerType : ObjectGraphType<CustomerDto>
    {
        public CustomerType()
        {
            Name = "Customer";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("ID of the customer");
            Field(x => x.FirstName).Description("First name of the customer");
            Field(x => x.LastName).Description("Last name of the customer");
            Field(x => x.DateOfBirth).Description("Customers date of birth");
            Field(x => x.Orders, type: typeof(ListGraphType<OrderType>)).Description("Customer orders");
        }
    }
}
