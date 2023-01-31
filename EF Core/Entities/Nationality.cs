using System.ComponentModel.DataAnnotations;

namespace EF_Core.Entities
{
    public class Nationality
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
