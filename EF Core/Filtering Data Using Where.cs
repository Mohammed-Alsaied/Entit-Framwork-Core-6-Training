using EF_Core.DbContexts;

namespace EF_Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Filtering Data Using Where
            var _context = new ApplicationDbContext();
            var stocks = _context.Stocks.Where(s => s.Id > 500).ToList();
            foreach (var stock in stocks)
                Console.WriteLine($"Id: {stock.Id} : {stock.Name}");
            stocks = _context.Stocks.Where(s => s.Name.StartsWith("Z")).ToList();
            foreach (var stock in stocks)
                Console.WriteLine($"Id: {stock.Id} : {stock.Name}");
            stocks = _context.Stocks.Where(s => s.Name.EndsWith("e")).ToList();
            foreach (var stock in stocks)
                Console.WriteLine($"Id: {stock.Id} : {stock.Name}");
            stocks = _context.Stocks.Where(s => s.IsActicve).ToList(); //where IsActicve is bool
            stocks = _context.Stocks.Where(s => !s.IsActicve).ToList(); //where IsActicve is bool

            #endregion
        }

    }
}
