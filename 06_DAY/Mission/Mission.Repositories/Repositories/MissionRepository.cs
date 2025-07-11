using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mission.Entities.Context;
using Mission.Entities.Entities;
using Mission.Entities.Models;
using Mission.Repositories.IRepositories;

namespace Mission.Repositories.Repositories
{
    public class MissionRepository : IMissionRepository
    {
        private readonly MissionDbContext _dbContext;
        public MissionRepository(MissionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<MissionDetailViewModel>> GetAllMissions()
        {
            return await _dbContext.MissionDetails
                .Select(m => new MissionDetailViewModel
                {
                    Id = m.Id,
                    Title = m.Title,
                    Description = m.Description,
                    ThemeId = m.ThemeId,
                    SkillId = m.SkillId,
                    Status = m.Status
                }).ToListAsync();
        }

        public async Task<MissionDetailViewModel?> GetMissionById(int missionId)
        {
            return await _dbContext.MissionDetails
                .Where(m => m.Id == missionId)
                .Select(m => new MissionDetailViewModel
                {
                    Id = m.Id,
                    Title = m.Title,
                    Description = m.Description,
                    ThemeId = m.ThemeId,
                    SkillId = m.SkillId,
                    Status = m.Status
                }).FirstOrDefaultAsync();
        }

        public async Task<bool> AddMission(MissionDetail mission)
        {
            _dbContext.MissionDetails.Add(mission);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateMission(MissionDetail mission)
        {
            var existing = await _dbContext.MissionDetails.FindAsync(mission.Id);
            if (existing == null) return false;
            existing.Title = mission.Title;
            existing.Description = mission.Description;
            existing.ThemeId = mission.ThemeId;
            existing.SkillId = mission.SkillId;
            existing.Status = mission.Status;
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteMission(int missionId)
        {
            var mission = await _dbContext.MissionDetails.FindAsync(missionId);
            if (mission == null) return false;
            _dbContext.MissionDetails.Remove(mission);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
