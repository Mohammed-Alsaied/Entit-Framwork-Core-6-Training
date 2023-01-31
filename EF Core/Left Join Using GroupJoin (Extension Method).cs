using EF_Core.DbContexts;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();

            var books = _context.Books
                .Join
                (
                    _context.Authors,
                    book => book.AuthorId,
                    author => author.Id,
                    (book, author) => new
                    {
                        BookId = book.Id,
                        BookName = book.Name,
                        AuthorName = author.Name,
                        AuthorNationalityId = author.NationalityId
                    }
                )
                .GroupJoin
                (
                    _context.Nationalities,
                    book => book.AuthorNationalityId,
                   nationality => nationality.Id,
                   (book, nationality) => new
                   {
                       Book = book,
                       Nationality = nationality,
                   }
                )
                .SelectMany(
                        b => b.Nationality.DefaultIfEmpty(),
                        (b, n) => new { b.Book, Nationality = n }
                    );
            foreach (var book in books)
                Console.WriteLine($"{book.Book.BookId} - {book.Book.BookName} - {book.Book.AuthorName} - {book.Nationality?.Name}");
        }
    }
}
