# GraphQL Example
## Installation
In the package manager console, enter the following command (it may take a minute)
```update-database -Context GraphQLTest.Domain.Company.CompanyDBContext```
## Example Queries
Customer Query
```
{
  customers(id: "1") 
  {
    id
    firstName
    lastName
    dateOfBirth
    orders {
      id
      orderDate
      lineItems {
        itemId
        quantity
      }
    }
  }
}
```
Order Query
```
{
  orders(id: "365")
  {
    id
    orderDate
    lineItems
    {
      id
      itemId
      quantity
    }
  }
}
```
## Resources
### Github Source
* GraphQL library used in this example https://github.com/graphql-dotnet/graphql-dotnet
* GraphiQL editor used in this example https://github.com/JosephWoodward/graphiql-dotnet
### Documentation
* Learn GraphQL - https://graphql.org/learn/
### Load Testing
https://github.com/codesenberg/bombardier
Bombardier is a great tool for testing your service.  You will find in the root of this project a file named "bombard.json", you can run the following command to load test
```bombardier -m POST -H "Content-Type: application/json" -f bombard.json http://localhost:5000/api/graphql```
