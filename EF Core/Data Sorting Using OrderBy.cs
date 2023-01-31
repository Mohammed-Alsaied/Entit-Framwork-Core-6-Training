namespace EF_Core
{
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        #region Data Sorting Using OrderBy
    //        var _context = new ApplicationDbContext();

    //        #region Data Sorting Using OrderBy Assending
    //        var stocks = _context.Stocks.OrderBy(x => x.Balance).ToList();//Assending
    //        var stocks = _context.Stocks.OrderBy(x => x.Balance).ThenBy(x => x.Balance).ToList();//Assending

    //        #endregion Data Sorting Using OrderBy Assending

    //        #region Data Sorting Using OrderBy Descending

    //        var stocks = _context.Stocks.OrderByDescending(x => x.Balance).ToList();//Descending
    //        var stocks = _context.Stocks.OrderByDescending(x => x.Balance).ThenByDescending(x => x.Balance).ToList();//Descending

    //        #endregion Data Sorting Using OrderBy Descending

    //        foreach (var stock in stocks)
    //            Console.WriteLine($"Id: {stock.Id}:{stock.Name} - Balance:{stock.Balance}");
    //        #endregion Data Sorting Using OrderBy
    //    }

    //}
}
