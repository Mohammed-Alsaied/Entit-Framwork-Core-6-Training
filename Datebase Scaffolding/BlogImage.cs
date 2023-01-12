using System;
using System.Collections.Generic;

namespace Datebase_Scaffolding
{
    public partial class BlogImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Caption { get; set; }
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
