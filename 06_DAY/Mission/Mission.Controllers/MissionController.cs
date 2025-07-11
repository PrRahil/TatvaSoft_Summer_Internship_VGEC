[ApiController]
[Route("api/[controller]")]
public class MissionController(IMissionService missionService) : ControllerBase
{
    private readonly IMissionService _missionService = missionService;

    [HttpGet]
    [Route("GetAllMissions")]
    public async Task<IActionResult> GetAllMissions()
    {
        var res = await _missionService.GetAllMissions();
        return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "" });
    }

    [HttpGet]
    [Route("GetMissionById/{id:int}")]
    public async Task<IActionResult> GetMissionById(int id)
    {
        var res = await _missionService.GetMissionById(id);
        if (res == null)
            return NotFound(new ResponseResult { Data = null, Result = ResponseStatus.Error, Message = "Not Found" });
        return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "" });
    }

    [HttpPost]
    [Route("AddMission")]
    public async Task<IActionResult> AddMission(MissionDetailViewModel model)
    {
        if (model == null || model.CountryId == 0 || model.CityId == 0)
            return BadRequest(new ResponseResult { Data = null, Result = ResponseStatus.Error, Message = "Country and City are required" });

        var res = await _missionService.AddMission(model);
        return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "Mission added" });
    }

    [HttpPost]
    [Route("UpdateMission")]
    public async Task<IActionResult> UpdateMission(MissionDetailViewModel model)
    {
        var res = await _missionService.UpdateMission(model);
        if (!res)
            return NotFound(new ResponseResult { Data = null, Result = ResponseStatus.Error, Message = "Not Found" });
        return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "Mission updated" });
    }

    [HttpDelete]
    [Route("DeleteMission/{id:int}")]
    public async Task<IActionResult> DeleteMission(int id)
    {
        var res = await _missionService.DeleteMission(id);
        if (!res)
            return NotFound(new ResponseResult { Data = null, Result = ResponseStatus.Error, Message = "Not Found" });
        return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "Mission deleted" });
    }
}