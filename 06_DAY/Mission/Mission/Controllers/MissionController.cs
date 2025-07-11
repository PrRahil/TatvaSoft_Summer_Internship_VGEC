using Microsoft.AspNetCore.Mvc;
using Mission.Entities;
using Mission.Entities.Models;
using Mission.Services.IServices;

namespace Mission.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MissionController(IMissionService missionService) : ControllerBase
    {
        private readonly IMissionService _missionService = missionService;

        [HttpGet]
        [Route("MissionList")]
        public async Task<IActionResult> GetAllMissions()
        {
            var res = await _missionService.GetAllMissions();
            return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "" });
        }

        [HttpGet]
        [Route("MissionDetailById/{id:int}")]
        public async Task<IActionResult> GetMissionById(int id)
        {
            var res = await _missionService.GetMissionById(id);
            if (res == null)
                return NotFound(new ResponseResult { Data = "Not Found", Result = ResponseStatus.Error, Message = "" });
            return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "" });
        }

        [HttpPost]
        [Route("AddMission")]
        public async Task<IActionResult> AddMission(MissionDetailViewModel model)
        {
            var res = await _missionService.AddMission(model);
            return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "" });
        }

        [HttpPost]
        [Route("UpdateMission")]
        public async Task<IActionResult> UpdateMission(MissionDetailViewModel model)
        {
            var res = await _missionService.UpdateMission(model);
            if (!res)
                return NotFound(new ResponseResult { Data = "Not Found", Result = ResponseStatus.Error, Message = "" });
            return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "" });
        }

        [HttpDelete]
        [Route("DeleteMission/{id:int}")]
        public async Task<IActionResult> DeleteMission(int id)
        {
            var res = await _missionService.DeleteMission(id);
            if (!res)
                return NotFound(new ResponseResult { Data = "Not Found", Result = ResponseStatus.Error, Message = "" });
            return Ok(new ResponseResult { Data = res, Result = ResponseStatus.Success, Message = "Record Deleted Successfully" });
        }
    }
}