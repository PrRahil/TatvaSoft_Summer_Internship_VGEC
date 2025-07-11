using Mission.Entities.Context;
using Mission.Entities.Models;
using Mission.Repositories.IRepositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission.Repositories.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly MissionDbContext _dbContext;
        public CityRepository(MissionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CityViewModel>> GetCitiesByCountryId(int countryId)
        {
            return await _dbContext.Cities
                .Where(c => c.CountryId == countryId)
                .Select(c => new CityViewModel { Id = c.Id, Name = c.Name, CountryId = c.CountryId })
                .ToListAsync();
        }
    }
}