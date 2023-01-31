namespace EF_Core
{
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        #region Take vs Skip

    //        #region Take
    //        var _context = new ApplicationDbContext();

    //        var stocks = GetData(5, 20);

    //        var stocks = _context.Stocks.Skip(0).Take(10).ToList();

    //        #endregion Take

    //        #region Skip
    //        var stocks = _context.Stocks.Skip(10).Take(10).ToList();


    //        #endregion Skip

    //        foreach (var stock in stocks)
    //            Console.WriteLine($"Id: {stock.Id}");
    //        #endregion  Take vs Skip
    //    }

    //    public static List<Stock> GetData(int pageNumber, int pageSize)
    //    {
    //        var _context = new ApplicationDbContext();

    //        return _context.Stocks.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
    //    }
    //}


}
