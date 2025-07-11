[ApiController]
[Route("api/[controller]")]
public class CountryController(ICountryService countryService) : ControllerBase
{
    private readonly ICountryService _countryService = countryService;

    [HttpGet]
    [Route("GetAllCountries")]
    public async Task<IActionResult> GetAllCountries()
    {
        var res = await _countryService.GetAllCountries();
        return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "" });
    }
}