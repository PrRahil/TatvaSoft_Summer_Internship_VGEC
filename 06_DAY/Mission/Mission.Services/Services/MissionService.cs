using Mission.Entities.Entities;
using Mission.Entities.Models;
using Mission.Repositories.IRepositories;
using Mission.Services.IServices;

namespace Mission.Services.Services
{
    public class MissionService : IMissionService
    {
        private readonly IMissionRepository _missionRepository;
        public MissionService(IMissionRepository missionRepository)
        {
            _missionRepository = missionRepository;
        }

        public Task<List<MissionDetailViewModel>> GetAllMissions()
        {
            return _missionRepository.GetAllMissions();
        }

        public Task<MissionDetailViewModel?> GetMissionById(int missionId)
        {
            return _missionRepository.GetMissionById(missionId);
        }

        public Task<bool> AddMission(MissionDetailViewModel model)
        {
            var mission = new MissionDetail
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                ThemeId = model.ThemeId,
                SkillId = model.SkillId,
                Status = model.Status
            };
            return _missionRepository.AddMission(mission);
        }

        public Task<bool> UpdateMission(MissionDetailViewModel model)
        {
            var mission = new MissionDetail
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                ThemeId = model.ThemeId,
                SkillId = model.SkillId,
                Status = model.Status
            };
            return _missionRepository.UpdateMission(mission);
        }

        public Task<bool> DeleteMission(int missionId)
        {
            return _missionRepository.DeleteMission(missionId);
        }
    }
}