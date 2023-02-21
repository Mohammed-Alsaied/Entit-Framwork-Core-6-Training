using EF_Core.DbContexts;
using EF_Core.Entities;

namespace EF_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            #region MaxBy vs MinBy
            List<Product> products = new()
            {
                new("Product 1",50.5),
                new("Product 2",20.25),
                new("Product 3",249.4),
                new("Product 4",357.0),
                new("Product 4",37.1),
            };

            #region MaxBy
            var mostExpensive = products.MaxBy(p => p.Price);
            var mostExpensive1 = products.OrderBy(p => p.Price).Last();
            var mostExpensive2 = products.OrderByDescending(p => p.Price).First();
            Console.WriteLine($"MostExpensive:{mostExpensive.Name}");
            #endregion MaxBy

            #region MinBy
            var cheapest = products.MinBy(p => p.Price);
            var cheapest = products.OrderBy(p => p.Price).First();
            Console.WriteLine($"Cheapest:{cheapest.Name}");
            #endregion MinBy

            #endregion MaxBy vs MinBy
        }
    }
}
