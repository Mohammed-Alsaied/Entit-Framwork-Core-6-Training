using EF_Core.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //var book = _context.Books.AsNoTracking().SingleOrDefault(b => b.Id == 1);
            var book = _context.Books.SingleOrDefault(b => b.Id == 1);
            book.Price = 110;
            _context.SaveChanges();

            var trackers = _context.ChangeTracker.Entries();
            foreach (var tracker in trackers)
            {
                Console.WriteLine($"{tracker.Entity.ToString()} - {tracker.State}");
            }
        }
    }
}
