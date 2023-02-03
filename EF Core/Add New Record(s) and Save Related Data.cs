using EF_Core.DbContexts;
using EF_Core.Entities;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            var nationality = new Nationality { Name = "New Nationality" };
            _context.Nationalities.Add(nationality);

            var nationalities = new List<Nationality>

            {
               new Nationality { Name = "New 2"},
               new Nationality { Name = "New 3"},
               new Nationality { Name = "New 4"},
               new Nationality { Name = "New 5"}
            };

            _context.Nationalities.AddRange(nationalities);

            #region Add New Record Using Navigation Property

            var author = new Author
            {
                Name = "New Author",
                Nationality = new Nationality { Name = "New 6" },
            };
            _context.Add(author);
            #endregion Add New Record Using Navigation Property

            #region Add New Record Using Collection Property
            var blog = new Blog
            {
                Url = "www.google.com",
                CreatedOn = DateTime.Now,
                Posts = new List<Post>
                {
                    new Post{ Content="Contect 1",Title ="Title 1"},
                    new Post{ Content="Contect 2",Title ="Title 2"},
                    new Post{ Content="Contect 3",Title ="Title 3"},
                    new Post{ Content="Contect 4",Title ="Title 4"},
                }
            };
            _context.Add(blog);
            #endregion  Add New Record Using Collection Property
            _context.SaveChanges();
        }
    }
}
