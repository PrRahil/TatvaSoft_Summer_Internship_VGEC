using Microsoft.AspNetCore.Mvc;
using Mission.Services.IServices;

namespace Mission.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommonController(
        ICountryService countryService,
        IMissionSkillService missionSkillService,
        IMissionThemeService missionThemeService
    ) : ControllerBase
    {
        private readonly ICountryService _countryService = countryService;
        private readonly IMissionSkillService _missionSkillService = missionSkillService;
        private readonly IMissionThemeService _missionThemeService = missionThemeService;

        [HttpGet("CountryList")]
        public async Task<IActionResult> CountryList()
        {
            var res = await _countryService.GetAllCountries();
            return Ok(res);
        }

        [HttpGet("MissionSkillList")]
        public async Task<IActionResult> MissionSkillList()
        {
            var res = await _missionSkillService.GetAllMissionSkill();
            return Ok(res);
        }

        [HttpGet("MissionThemeList")]
        public async Task<IActionResult> MissionThemeList()
        {
            var res = await _missionThemeService.GetAllMissionTheme();
            return Ok(res);
        }
    }
}