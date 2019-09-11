using System.Linq;
using GraphQlGdpr.Api.Data.Entities;

namespace GraphQlGdpr.Api
{
    public static class InitialData
    {
        public static void Seed(this GdprDbContext context)
        {
            if (!context.Persons.Any())
            {
                context.Persons.Add(new Person
                {
                    FirstName = "Henk",
                    LastName = "De Vries",
                    StreetName = "Steenstraat",
                    HouseNumber = "10E"
                });

                context.Persons.Add(new Person
                {
                    FirstName = "Bram",
                    LastName = "Jansen",
                    StreetName = "Wagenstraat",
                    HouseNumber = "22A"
                });

                context.Persons.Add(new Person
                {
                    FirstName = "Sean",
                    LastName = "De Jong",
                    StreetName = "Haarlemmerstraat",
                    HouseNumber = "66Q"
                });

                context.SaveChanges();
            }
        }
    }
}
