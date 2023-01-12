using System;
using System.Collections.Generic;

namespace Datebase_Scaffolding
{
    public partial class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public virtual BlogImage BlogImage { get; set; }
    }
}
