namespace EF_Core
{
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        var _context = new ApplicationDbContext();
    //        #region Using Navigation Property
    //        var book = _context.Books
    //            .SingleOrDefault(b => b.Id == 2);
    //        _context.Entry(book).Reference(b => b.Author).Load();

    //        Console.WriteLine(book.Author.Nationality.Name);
    //        #endregion Using Navigation Property

    //        #region Using Collection Property
    //        var blog = _context.Blogs
    //            .SingleOrDefault(b => b.Id == 2);
    //        //_context.Entry(blog).Collection(b => b.Posts).Load();
    //        _context.Entry(blog)
    //            .Collection(b => b.Posts)
    //            .Query()
    //            .Where(b => b.Id == 2)
    //            .ToList();

    //        foreach (var post in blog.Posts)
    //        {
    //            Console.WriteLine(post.Title);
    //        }
    //        #endregion Using Collection Property
    //    }
    //}
}
