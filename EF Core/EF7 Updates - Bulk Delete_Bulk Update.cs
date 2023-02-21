using EF_Core.DbContexts;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();

            #region EF7 Updates - Bulk Delete_Bulk Update
            _context.Blogs.Skip(950).ExecuteDelete();
            _context.Blogs.Where(e => e.Id > 950).ExecuteDelete();

            _context.Blogs.Where(e => e.Id > 900)
                .ExecuteUpdate(p => p.SetProperty(e => e.Url, e => e.Url + " updated"));
            #endregion EF7 Updates - Bulk Delete_Bulk Update
        }
    }
}
