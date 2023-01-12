using EF_Core.DbContexts;

namespace EF_Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Any vs All
            var _context = new ApplicationDbContext();

            #region Any
            var stocks = _context.Stocks.Any();
            Console.WriteLine(stocks);
            stocks = _context.Stocks.Any(s => s.Id > 500);
            Console.WriteLine(stocks);
            stocks = _context.Stocks.Any(s => s.Id > 1000);
            Console.WriteLine(stocks);
            #endregion Any

            #region All
            //var stocks = _context.Stocks.All(); 
            //Console.WriteLine(stocks);
            var stocks = _context.Stocks.All(s => s.Id > 0);
            Console.WriteLine(stocks);
            stocks = _context.Stocks.All(s => s.Id > 1000);
            Console.WriteLine(stocks);
            #endregion All

            #endregion Any vs All
        }

    }
}
