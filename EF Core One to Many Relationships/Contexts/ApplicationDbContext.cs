
namespace EFCore_One_to_Many_Relationships.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=EF Core One to Many Relationships ;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BlogEntityTypeConfigurations().Configure(modelBuilder.Entity<Blog>());
            new PostEntityTypeConfigurations().Configure(modelBuilder.Entity<Post>());
            new CarEntityTypeConfigurations().Configure(modelBuilder.Entity<Car>());
            new RecordOfSaleEntityTypeConfigurations().Configure(modelBuilder.Entity<RecordOfSale>());


        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<RecordOfSale> RecordOfSales { get; set; }



    }
}
