using Mission.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mission.Services.IServices
{
    public interface ICityService
    {
        Task<List<CityViewModel>> GetCitiesByCountryId(int countryId);
    }
}