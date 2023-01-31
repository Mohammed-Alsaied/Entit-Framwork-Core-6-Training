using EF_Core.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();

            var book = _context.Books
                .Include(b => b.Author)
                .ThenInclude(a => a.Nationality)
                .SingleOrDefault(b => b.Id == 2);

            Console.WriteLine(book.Author.Nationality.Name);
        }
    }
}
