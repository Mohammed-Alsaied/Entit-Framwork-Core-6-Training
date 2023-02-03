using EF_Core.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();

            var postsWithGlobalQueryFilter = _context.Posts.ToList();//with Global HasQueryFilter
            var postsWithoutGlobalQueryFilter = _context.Posts.Where(p => !p.IsDeleted).ToList();//without HasQueryFilter
            foreach (var post in postsWithGlobalQueryFilter)
            {
                Console.WriteLine(post.Title);
            }

            var blogs = _context.Blogs.ToList();
            var blogsWithIgnoreQureyFilters = _context.Blogs.IgnoreQueryFilters().ToList();
            foreach (var blog in blogs)
            {
                Console.WriteLine(blog.Id);
            }

        }
    }
}
