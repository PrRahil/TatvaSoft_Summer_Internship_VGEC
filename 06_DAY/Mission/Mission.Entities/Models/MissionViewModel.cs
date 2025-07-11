using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities.Models
{
    public class MissionDetailViewModel
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string Title { get; set; }
        public int ThemeId { get; set; }
        public string Description { get; set; }
        public int SeatNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ImagePath { get; set; }
        public int SkillId { get; set; }
        public string Status { get; set; }
    }
}
