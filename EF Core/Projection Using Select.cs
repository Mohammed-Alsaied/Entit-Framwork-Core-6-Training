namespace EF_Core
{
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        #region Projection Using Select
    //        var _context = new ApplicationDbContext();

    //        #region Projection Using Select by Anonymous Object
    //        var stocks = _context.Stocks.Select(s => new { StockId = s.Id, StockName = s.Name }).ToList();
    //        var stocks = _context.Stocks.Select(s => new { s.Id, s.Name }).ToList();

    //        #endregion Projection Using Select by Anonymous Object

    //        #region Projection Using Select by Another Object

    //        var stocks = _context.Stocks.Select(s => new Blog { Id = s.Id, Url = s.Name }).ToList();

    //        #endregion Projection Using Select by Another Object

    //        foreach (var stock in stocks)
    //            Console.WriteLine($"Id: {stock.Id}:{stock.Url}");
    //        #endregion Projection Using Select
    //    }

    //}
}
