using EF_Core.DbContexts;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            #region Transaction
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Blogs.Add(new Entities.Blog { Url = "Test from transaction 1" });
                _context.SaveChanges();
                _context.Blogs.Add(new Entities.Blog { Url = "Test from transaction 2" });
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
            #endregion Transaction

            #region Transaction Uisng SavePoint
            try
            {
                _context.Blogs.Add(new Entities.Blog { Url = "Test from transaction 1" });
                _context.SaveChanges();
                transaction.CreateSavepoint("AddFitrstBlog");
                _context.Blogs.Add(new Entities.Blog { Url = "Test from transaction 2" });
                _context.Blogs.Add(new Entities.Blog { Url = "Test from transaction 3" });
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.RollbackToSavepoint("AddFitrstBlog");
                transaction.Commit();
            }
            #endregion Transaction
        }
    }
}
