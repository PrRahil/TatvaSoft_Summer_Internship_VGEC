using Microsoft.AspNetCore.Mvc;
using Mission.Services.IServices;
using Mission.Entities;

namespace Mission.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController(ICountryService countryService) : ControllerBase
    {
        private readonly ICountryService _countryService = countryService;

        [HttpGet]
        [Route("CountryList")]
        public async Task<IActionResult> GetAllCountries()
        {
            var res = await _countryService.GetAllCountries();
            return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "" });
        }
    }
}