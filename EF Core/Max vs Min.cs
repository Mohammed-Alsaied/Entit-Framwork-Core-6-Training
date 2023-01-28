using EF_Core.DbContexts;

namespace EF_Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Max vs Min
            var _context = new ApplicationDbContext();

            #region Max
            var stocks = _context.Stocks.Max(s => s.Balance);
            var stocks1 = _context.Stocks.Max(s => s.Id);
            stocks = _context.Stocks.Max(s => s.Name);
            Console.WriteLine(stocks);
            Console.WriteLine(stocks1);
            #endregion Max

            #region Min
            var stocks2 = _context.Stocks.Min(s => s.Balance);
            var stocks3 = _context.Stocks.Min(s => s.Id);
            stocks2 = _context.Stocks.Min(s => s.Name);
            Console.WriteLine(stocks2);
            Console.WriteLine(stocks3);
            #endregion Min

            #endregion Max vs Min
        }

    }
}
