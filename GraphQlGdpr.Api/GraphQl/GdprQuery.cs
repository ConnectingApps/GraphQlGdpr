using GraphQL.Types;
using GraphQlGdpr.Api.GraphQl.Types;
using GraphQlGdpr.Api.Respositories;

namespace GraphQlGdpr.Api.GraphQl
{
    public class GdprQuery : ObjectGraphType
    {
        public GdprQuery(PersonRepository personRepository)
        {
            Field<ListGraphType<PersonType>>(
                "persons",
                resolve: context => personRepository.GetAll()
            );

            Field<PersonType>(
                "person",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                    { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return personRepository.GetOne(id);
                }
            );
        }
    }
}
