using EF_Core.DbContexts;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            #region Remove Record

            var nationality = _context.Nationalities.Find(10);
            _context.Remove(nationality);
            #endregion Remove Record

            #region Remove Range
            var nationalities = _context.Nationalities.Where(p => p.Id >= 6 & p.Id <= 8);
            _context.Nationalities.RemoveRange(nationalities);
            #endregion  Remove Range
            _context.SaveChanges();
        }
    }
}
