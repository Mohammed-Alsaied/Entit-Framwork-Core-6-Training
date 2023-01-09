namespace EFCore.Entities
{
    public class AuditEntry
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string Action { get; set; }
    }
}