namespace EF_Core
{
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        #region Select One Item Using Last
    //        //var _context = new ApplicationDbContext();
    //        //var stock = _context.Stocks.Last();//System.InvalidOperationException: Queries performing 'Last' operation must have a deterministic sort order. Rewrite the query to apply an 'OrderBy' operation on the sequence before calling 'Last'.
    //        //Console.WriteLine(stock == null ? "Item not found!" : $"Id: {stock.Id}: {stock.Name}");
    //        //var stock5 = _context.Stocks.OrderBy(s => s.Id).Last();
    //        //Console.WriteLine(stock5 == null ? "Item not found!" : $"Id: {stock5.Id}: {stock5.Name}");
    //        //var stock1 = _context.Stocks.OrderBy(s => s.Id).Last(s => s.Id > 500);
    //        //Console.WriteLine($"Id: {stock1.Id}: {stock1.Name}");
    //        //var stock2 = _context.Stocks.OrderBy(s => s.Id).Last(s => s.Id == 10000);//InvalidOperationException: Sequence contains no elements
    //        //Console.WriteLine(stock2 == null ? "Item not found!" : $"Id: {stock2.Id}: {stock2.Name}");
    //        //var stock3 = _context.Stocks.OrderBy(s => s.Id).LastOrDefault(s => s.Id == 10000);
    //        //Console.WriteLine(stock3 == null ? "Item not found!" : $"Id: {stock3.Id}: {stock3.Name}");
    //        #endregion
    //    }

    //}
}