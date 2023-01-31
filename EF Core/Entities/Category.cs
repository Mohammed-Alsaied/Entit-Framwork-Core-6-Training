using System;
using System.Collections.Generic;

namespace EF_Core.Entities
{
    public partial class Category
    {
        public byte Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
