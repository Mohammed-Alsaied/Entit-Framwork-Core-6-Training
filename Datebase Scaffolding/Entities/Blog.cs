using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datebase_Scaffolding.Entities
{
    public partial class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(1000)]
        public string Url { get; set; }

        [InverseProperty("Blog")]
        public virtual BlogImage BlogImage { get; set; }
    }
}
