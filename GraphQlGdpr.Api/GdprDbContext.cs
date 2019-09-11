using GraphQlGdpr.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQlGdpr.Api
{
    public class GdprDbContext : DbContext
    {
        public GdprDbContext(DbContextOptions<GdprDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}