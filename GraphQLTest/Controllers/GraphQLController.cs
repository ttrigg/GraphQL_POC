using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using GraphQLFoundation.Models;
using GraphQLFoundation.Services.Company;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphQLController : ControllerBase
    {
        private readonly ICompany _companyContext;

        public GraphQLController(ICompany companyContext)
        {
            _companyContext = companyContext;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<CustomerDto> Get(int id)
        {
            return await _companyContext
                .GetCustomerById(id)
                .ConfigureAwait(false);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQlQuery query)
        {
            var inputs = query.Variables.ToInputs();

            var schema = new Schema()
            {
                Query = new GraphQL.GraphQueryType(_companyContext)
            };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
