using System.ComponentModel.DataAnnotations;

namespace Mission.Entities.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}