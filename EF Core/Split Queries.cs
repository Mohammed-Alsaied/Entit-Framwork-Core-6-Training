using EF_Core.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using by Eager Loading only
            var _context = new ApplicationDbContext();
            var blog = _context.Blogs
                .Include(b => b.Posts).AsSplitQuery().ToList();
                .Include(b => b.Posts).AsSingleQuery().ToList();
        }
    }
}
