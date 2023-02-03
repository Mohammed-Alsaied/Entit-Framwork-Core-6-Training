using EF_Core.DbContexts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();

            #region Select Data Using SQL Statement
            var booksSQLStatement = _context.Books.FromSqlRaw("SELECT * FROM Books").ToList();
            foreach (var book in booksSQLStatement)
            {
                Console.WriteLine(book.Name);
            }

            #endregion Select Data Using SQL Statement

            #region Select Data Using Stored Procedure
            var bookId = new SqlParameter("Id", 1);
            var bookId = 1;//must perform validation to avoid SQL Injection
            var booksStoredProcedure = _context.Books.FromSqlRaw("prc_GetAllBooks").ToList();
            var booksStoredProcedure = _context.Books.FromSqlRaw($"prc_GetBookById {bookId}").ToList();
            var booksStoredProcedure = _context.Books.FromSqlRaw("prc_GetBookById @Id", bookId).ToList();//SqlParameter
            foreach (var book in booksStoredProcedure)
            {
                Console.WriteLine(book.Name);
            }

            #endregion Select Data Using Stored Procedure

        }
    }
}
