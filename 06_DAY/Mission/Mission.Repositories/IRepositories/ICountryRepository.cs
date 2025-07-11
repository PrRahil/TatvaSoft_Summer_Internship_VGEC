using Mission.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mission.Repositories.IRepositories
{
    public interface ICountryRepository
    {
        Task<List<Mission.Entities.Models.CountryViewModel>> GetAllCountries();
    }
}