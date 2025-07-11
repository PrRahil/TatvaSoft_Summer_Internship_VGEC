[ApiController]
[Route("api/[controller]")]
public class CityController(ICityService cityService) : ControllerBase
{
    private readonly ICityService _cityService = cityService;

    [HttpGet]
    [Route("CityList/{countryId:int}")]
    public async Task<IActionResult> GetCitiesByCountryId(int countryId)
    {
        var res = await _cityService.GetCitiesByCountryId(countryId);
        return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "" });
    }
}