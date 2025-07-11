using Mission.Entities.Context;
using Mission.Entities.Models;
using Mission.Repositories.IRepositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission.Repositories.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly MissionDbContext _dbContext;
        public CountryRepository(MissionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CountryViewModel>> GetAllCountries()
        {
            return await _dbContext.Countries
                .Select(c => new CountryViewModel { Id = c.Id, Name = c.Name })
                .ToListAsync();
        }
    }
}