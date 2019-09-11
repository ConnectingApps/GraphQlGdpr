using GraphQL;
using GraphQL.Types;

namespace GraphQlGdpr.Api.GraphQl
{
    public class GdprSchema : Schema
    {
        public GdprSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<GdprQuery>();
        }
    }
}
