using EF_Core.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();


            #region Select Data Using Stored Procedure
            var booksStoredProcedure = _context.BookDto.FromSqlRaw("prc_GetAllBooksWithAuthors").ToList();
            foreach (var book in booksStoredProcedure)
            {
                Console.WriteLine(book.Name);
            }

            #endregion Select Data Using Stored Procedure

        }
    }
}
