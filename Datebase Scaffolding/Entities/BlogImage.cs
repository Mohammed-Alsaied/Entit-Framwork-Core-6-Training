using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Datebase_Scaffolding.Entities
{
    [Index("BlogId", Name = "IX_BlogImages_BlogId", IsUnique = true)]
    public partial class BlogImage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Caption { get; set; }
        public int BlogId { get; set; }

        [ForeignKey("BlogId")]
        [InverseProperty("BlogImage")]
        public virtual Blog Blog { get; set; }
    }
}
