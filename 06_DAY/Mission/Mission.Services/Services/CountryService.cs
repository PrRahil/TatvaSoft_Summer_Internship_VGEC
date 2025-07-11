using Mission.Entities.Models;
using Mission.Repositories.IRepositories;
using Mission.Services.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mission.Services.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public Task<List<CountryViewModel>> GetAllCountries()
        {
            return _countryRepository.GetAllCountries();
        }
    }
}