using System;
using System.Collections.Generic;

namespace EF_Core.Entities
{
    public partial class AuditEntry
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Action { get; set; }
    }
}
