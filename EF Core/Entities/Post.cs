using System;
using System.Collections.Generic;

namespace EF_Core.Entities
{
    public partial class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int? BlogId { get; set; }

        public virtual Blog? Blog { get; set; }
    }
}
