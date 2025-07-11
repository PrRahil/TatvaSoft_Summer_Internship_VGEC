using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mission.Entities.Entities;
using Mission.Entities.Models;

namespace Mission.Repositories.IRepositories
{
    public interface IMissionRepository
    {
        Task<List<MissionDetailViewModel>> GetAllMissions();
        Task<MissionDetailViewModel?> GetMissionById(int missionId);
        Task<bool> AddMission(MissionDetail mission);
        Task<bool> UpdateMission(MissionDetail mission);
        Task<bool> DeleteMission(int missionId);
    }
}
