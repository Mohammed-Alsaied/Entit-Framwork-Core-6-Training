namespace EF_Core
{
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        #region Average vs Count vs Sum
    //        var _context = new ApplicationDbContext();

    //        #region Average
    //        var stocks = _context.Stocks.Average(s => s.Id);
    //        stocks = _context.Stocks.Where(s => s.Id > 900).Average(s => s.Id);
    //        Console.WriteLine(stocks);
    //        #endregion Average

    //        #region Count
    //        stocks = _context.Stocks.Count(s => s.Id > 500);
    //        stocks = _context.Stocks.LongCount(s => s.Id > 500);
    //        Console.WriteLine(stocks);
    //        #endregion Count

    //        #region Sum
    //        stocks = _context.Stocks.Sum(s => s.Id);
    //        stocks = _context.Stocks.Where(s => s.Id > 900).Sum(s => s.Id);
    //        Console.WriteLine(stocks);
    //        #endregion Sum
    //        #endregion Any vs All
    //    }

    //}
}
