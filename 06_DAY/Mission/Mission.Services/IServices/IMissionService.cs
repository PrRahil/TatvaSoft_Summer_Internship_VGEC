using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mission.Entities.Models;

namespace Mission.Services.IServices
{
    public interface IMissionService
    {
        Task<List<MissionDetailViewModel>> GetAllMissions();
        Task<MissionDetailViewModel?> GetMissionById(int missionId);
        Task<bool> AddMission(MissionDetailViewModel model);
        Task<bool> UpdateMission(MissionDetailViewModel model);
        Task<bool> DeleteMission(int missionId);
    }
}
