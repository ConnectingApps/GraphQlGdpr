using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQlGdpr.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQlGdpr.Api.Respositories
{
    public class PersonRepository
    {
        private readonly GdprDbContext _dbContext;

        public PersonRepository(GdprDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _dbContext.Persons.ToListAsync();
        }

        public Task<Person> GetOne(int id)
        {
            return _dbContext.Persons.SingleAsync(p => p.Id == id);
        }
    }
}
