using EF_Core.DbContexts;

namespace EF_Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Select One Item Using First
            var _context = new ApplicationDbContext();
            var stock = _context.Stocks.First();//only one item
            Console.WriteLine(stock == null ? "Item not found!" : $"Id: {stock.Id}: {stock.Name}");
            var stock1 = _context.Stocks.First(s => s.Id > 500);
            Console.WriteLine($"Id: {stock1.Id}: {stock1.Name}");
            var stock2 = _context.Stocks.First(s => s.Id == 10000);//InvalidOperationException: Sequence contains no elements
            Console.WriteLine(stock2 == null ? "Item not found!" : $"Id: {stock2.Id}: {stock2.Name}");
            var stock3 = _context.Stocks.FirstOrDefault(s => s.Id == 10000);
            Console.WriteLine(stock3 == null ? "Item not found!" : $"Id: {stock3.Id}: {stock3.Name}");
            #endregion
        }

    }
}