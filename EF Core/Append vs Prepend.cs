using EF_Core.DbContexts;
using EF_Core.Entities;

namespace EF_Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Append vs Prepend
            var _context = new ApplicationDbContext();

            #region Append
            var stocks = _context.Stocks.Where(s => s.Id > 900).ToList().Append(new Stock { Id = 1001, Name = "test" });//add data last of list
            foreach (var stock in stocks)
            {
                Console.WriteLine($"Id:{stock.Id}:Name:{stock.Name}");
            }
            #endregion Append

            #region Prepend
            var stocks = _context.Stocks.Where(s => s.Id > 900).ToList().Prepend(new Stock { Id = 1001, Name = "test" });//add data First of list
            foreach (var stock in stocks)
            {
                Console.WriteLine($"Id:{stock.Id}:Name:{stock.Name}");
            }
            #endregion Prepend

            #endregion Any vs All
        }

    }
}
