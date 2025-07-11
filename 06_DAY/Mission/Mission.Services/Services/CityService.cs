using Mission.Entities.Models;
using Mission.Repositories.IRepositories;
using Mission.Services.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mission.Services.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public Task<List<CityViewModel>> GetCitiesByCountryId(int countryId)
        {
            return _cityRepository.GetCitiesByCountryId(countryId);
        }
    }
}