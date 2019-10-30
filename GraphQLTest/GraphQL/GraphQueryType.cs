using GraphQL.Types;
using GraphQLTest.Services.Company;

namespace GraphQLTest.GraphQL
{
    public class GraphQueryType : ObjectGraphType
    {
        public GraphQueryType(ICompany companyContext)
        {
            // Query on customers id
            FieldAsync<CustomerType>(
                "customers",
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id", Description = "The id of the customer." }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");

                    return await companyContext
                        .GetCustomerById(id);
                });

            // Support order ID
            FieldAsync<OrderType>(
                "orders",
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the order." }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");

                    return await companyContext
                        .GetOrderById(id);
                });

        }
    }
}
