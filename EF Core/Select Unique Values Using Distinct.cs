using EF_Core.DbContexts;

namespace EF_Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Select Unique Values Using Distinct
            var _context = new ApplicationDbContext();

            var stocks = _context.Stocks.Select(s => new { StockId = s.Id, StockName = s.Name }).Distinct().ToList();
            var stocks = _context.Stocks.Select(s => new { s.Industry }).Distinct().ToList();

            foreach (var stock in stocks)
                Console.WriteLine($"Id: {stock.StockId}:{stock.StockName}");
            Console.WriteLine($"Id: {stock.Industry}");
            #endregion  Select Unique Values Using Distinct
        }

    }
}
