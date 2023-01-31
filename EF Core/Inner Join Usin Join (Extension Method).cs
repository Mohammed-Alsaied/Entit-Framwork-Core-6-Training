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
                .Join
                (
                    _context.Nationalities,
                    book => book.AuthorNationalityId,
                   nationality => nationality.Id,
                   (book, nationality) => new
                   {
                       book.BookId,
                       book.BookName,
                       book.AuthorName,
                       AuthorNationality = nationality.Name
                   }
                );
            foreach (var book in books)
                Console.WriteLine($"{book.BookId} - {book.BookName} - {book.AuthorName} - {book.AuthorNationality}");
        }
    }
}
