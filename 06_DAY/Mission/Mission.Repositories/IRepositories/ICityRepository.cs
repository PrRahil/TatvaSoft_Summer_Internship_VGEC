using Mission.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mission.Repositories.IRepositories
{
    public interface ICityRepository
    {
        Task<List<CityViewModel>> GetCitiesByCountryId(int countryId);
    }
}