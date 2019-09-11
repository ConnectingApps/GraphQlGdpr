using GraphQL.Types;
using GraphQlGdpr.Api.Data.Entities;

namespace GraphQlGdpr.Api.GraphQl.Types
{
    public class PersonType : ObjectGraphType<Person>
    {
        public PersonType()
        {
            Field(t => t.Id).Description("Primary key");
            Field(t => t.HouseNumber).Description("Number of the house");
            Field(t => t.FirstName).Description("First Name");
            Field(t => t.LastName).Description("Last Name");
            Field(t => t.StreetName).Description("Street Name");
        }
    }
}
