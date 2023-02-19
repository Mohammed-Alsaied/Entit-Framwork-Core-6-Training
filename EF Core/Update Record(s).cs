using EF_Core.DbContexts;
using EF_Core.Entities;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            #region Update Record one or 2 property

            var nationality = _context.Nationalities.Find(10);
            nationality.Name = "New 10";
            #endregion Update Record one or 2 property

            #region Update Record Object
            var nationality = new Nationality { Id = 10, Name = "New 11" };
            _context.Update(nationality);

            #endregion Update Record Object

            #region Update Record Using Entry()
            var currentNationality = _context.Nationalities.Find(10);
            var newNationality = new Nationality { Id = 10, Name = "New 12" };
            _context.Entry(currentNationality).CurrentValues.SetValues(newNationality);

            #endregion  Update Record Using Entry()

            #region Update Partial Property
            var post = new Post
            {
                Id = 9,
                BlogId = 4,
                Content = "Update Content",
                IsDeleted = true,
            };
            _context.Update(post);
            _context.Entry(post).Property(p => p.BlogId).IsModified = false;
            _context.Entry(post).Property(p => p.Title).IsModified = false;
            #endregion  Update Partial Property

            #region Update Range
            var posts = _context.Posts.Where(p => !p.IsDeleted).ToList();
            foreach (var post in posts)
            {
                post.IsDeleted = true;
            }
            _context.UpdateRange(posts);
            #endregion  Update Range
            _context.SaveChanges();
        }
    }
}
