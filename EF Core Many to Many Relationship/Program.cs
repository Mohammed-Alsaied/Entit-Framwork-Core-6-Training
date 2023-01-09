//var _context = new ApplicationDbContext();

//var order = new Order
//{
//    Amount = 100
//};
//_context.Orders.Add(order);

//var orderTest = new OrderTest
//{
//    Amount = 100,
//};
//_context.OrdersTest.Add(orderTest);



//_context.SaveChanges();

using EFCore_Relationships.Contexts;

internal class Program
{
    public static void Main(string[] args)
    {
        SeedData();
    }

    public static void SeedData() // Custom Intialization 
    {
        using (var context = new ApplicationDbContext())
        {
            context.Database.EnsureCreated();
            var post = context.Posts.FirstOrDefault(p => p.Title == "post");
            if (post == null)
                context.Posts.Add(new Post { Title = "Post2" });
            context.SaveChanges();
        }
    }
}