using EF_Core.DbContexts;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            #region Delete Related Data Using Restrict

            var blog = _context.Blogs.Find(2);
            _context.Remove(blog);
            #endregion Delete Related Data

            #region Delete Related Data Remove Range
            var blog = _context.Blogs.Find(10);
            var posts = _context.Posts.Where(p => p.BlogId == 2);
            _context.RemoveRange(posts);
            _context.SaveChanges();
            _context.Remove(blog);
            #endregion Delete Related Data Remove Range

            #region Delete Related Data Using Setnull

            var blog = _context.Blogs.Find(3);
            _context.Remove(blog);
            #endregion Delete Related Data
            _context.SaveChanges();
        }
    }
}
