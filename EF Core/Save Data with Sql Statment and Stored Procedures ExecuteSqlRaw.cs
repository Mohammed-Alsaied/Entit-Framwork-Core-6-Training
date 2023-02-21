using EF_Core.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            #region Save Data with Sql Statment
            _context.Database.ExecuteSqlRaw("INSERT INTO Blogs VALUES ('Test 1')");
            #endregion Save Data with Sql Statment

            #region Stored Procedures ExecuteSqlRaw
            var name = "Test 3";
            _context.Database.ExecuteSqlRaw("prcAddBlog @Name-'Test 2'");
            _context.Database.ExecuteSqlRaw($"prcAddBlog @Name-N'{name}',@Value");//N for arabic chraachter
            #endregion Stored Procedures ExecuteSqlRaw

        }
    }
}
