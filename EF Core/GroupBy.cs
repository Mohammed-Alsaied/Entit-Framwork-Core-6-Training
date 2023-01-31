namespace EF_Core
{
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        #region GroupBy

    //        var _context = new ApplicationDbContext();

    //        var Industries = _context.Stocks
    //            .GroupBy(x => x.Industry)
    //            .Select(m => new { Name = m.Key, StockCount = m.Count(), BalanceSum = m.Sum(m => m.Balance), BalanceAverage = m.Average(x => x.Balance) })
    //            .OrderByDescending(m => m.StockCount);

    //        foreach (var Industry in Industries)
    //            Console.WriteLine($" {Industry.Name} - {Industry.StockCount} - {Industry.BalanceSum} - {Industry.BalanceAverage}");
    //        #endregion  GroupBy
    //    }


    //}


}
