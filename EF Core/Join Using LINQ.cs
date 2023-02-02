using EF_Core.DbContexts;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();

            #region Inner join
            var booksInnerjoin = (from b in _context.Books
                                  join a in _context.Authors
                                  on b.AuthorId equals a.Id
                                  join n in _context.Nationalities
                                  on a.NationalityId equals n.Id
                                  select new
                                  {
                                      BookId = b.Id,
                                      BookName = b.Name,
                                      AuthorName = a.Name

                                  }).ToList();
            ////}).Cpunt();

            #endregion Inner join

            #region Left join
            var booksLeftjoin = (from b in _context.Books
                                 join a in _context.Authors
                                 on b.AuthorId equals a.Id
                                 join n in _context.Nationalities
                                 on a.NationalityId equals n.Id into authorNationality
                                 from an in authorNationality.DefaultIfEmpty()

                                 select new
                                 {
                                     BookId = b.Id,
                                     BookName = b.Name,
                                     AuthorName = a.Name

                                 }).ToList();
            //}).Cpunt();
            #endregion Left join

        }
    }
}
