using System.ComponentModel.DataAnnotations;

namespace Mission.Entities.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}