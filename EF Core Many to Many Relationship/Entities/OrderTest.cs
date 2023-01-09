namespace EFCore_Relationships.Contexts
{
    public partial class ApplicationDbContext
    {
        public class OrderTest
        {
            public int Id { get; set; }
            public long OrderNo { get; set; }
            public double Amount { get; set; }
        }
    }
}