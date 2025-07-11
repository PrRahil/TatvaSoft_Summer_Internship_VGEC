using Mission.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mission.Services.IServices
{
    public interface ICountryService
    {
        Task<List<CountryViewModel>> GetAllCountries();
    }
}