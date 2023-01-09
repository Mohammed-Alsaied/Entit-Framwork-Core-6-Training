using Microsoft.EntityFrameworkCore;

namespace EFCoreFundamentals.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore;Integrated Security=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Add Domain Model

            //modelBuilder.Entity<AuditEntry>();//3.Add Domain Model

            #endregion Add Domain Model

            #region EntityTypeConfiguration

            //new EmployeeEntityTypeConfiguration().Configure(modelBuilder.Entity<Employee>());
            //new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());
            //new BookEntityTypeConfiguration().Configure(modelBuilder.Entity<Book>());
            //new AuthorEntityTypeConfiguration().Configure(modelBuilder.Entity<Author>());
            //new CategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<Category>());


            #endregion EntityTypeConfiguration

            #region Execlud a class from Domain Model Uisng Fluent API0

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeEntityTypeConfiguration).Assembly);
            //modelBuilder.Ignore<Post>();// 1.Execlud a class from Domain Model Uisng Fluent API

            #endregion Execlud a class from Domain Model Uisng Fluent API0

            #region Execlud Table From Migration

            //modelBuilder.Entity<Blog>()//Execlud Table From Migration
            //    .ToTable("Blogs", b => b.ExcludeFromMigrations());

            #endregion Execlud Table From Migration

            #region Change Table Name in DB Using Fluent API

            //modelBuilder.Entity<Post>() //Change Table Name in DB Using Fluent API
            //    .ToTable("Posts");

            #endregion Change Table Name in DB Using Fluent API

            #region Change Schema Name in DB Uisng Fluent API

            //modelBuilder.Entity<Post>()
            //    .ToTable("Posts", schema: "blogging");////Change Schema Name in DB Uisng Fluent API

            #endregion Change Schema Name in DB Uisng Fluent API

            #region Mapping to View

            //modelBuilder.Entity<Post>()
            //    .ToView("SelectPosts", schema: "blogging");//Mapping to View

            #endregion Mapping to View

            #region efault Schema for all tables will be Creates

            //modelBuilder.HasDefaultSchema("blogging");// Default Schema for all tables will be Creates

            #endregion efault Schema for all tables will be Creates

            #region Execlud a property from Domain Model Uisng Uisng Fluent API

            //modelBuilder.Entity<Blog>()
            ////2.Execlud a property from Domain Model Uisng Uisng Fluent API
            //    .Ignore(b => b.AddedOn);

            #endregion Execlud a property from Domain Model Uisng Uisng Fluent API

            #region Change property Name in DB Uisng Fluent API

            //1.Change property Name in DB Uisng Fluent API
            //modelBuilder.Entity<Blog>()
            //    .Property(b => b.Url)
            //    .HasColumnName("Blogurl");

            #endregion Change property Name in DB Uisng Fluent API

            #region Change Property Type in DB Uisng Fluent API

            //modelBuilder.Entity<Blog>(eb =>
            //{
            //    eb.Property(b => b.Url).HasColumnType("varchar(200)");
            //    eb.Property(b => b.Rating).HasColumnType("decimal(5,2)");

            //});

            #endregion Change Property Type in DB Uisng Fluent API
        }

        #region Add Domain Model

        //public DbSet<Employee> Employees { get; set; }//1.Add Domain Model

        //public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Book> Books { get; set; }

        //public DbSet<Author> Authors { get; set; }
        //public DbSet<Category> Categories { get; set; }



        #endregion Add Domain Model
    }
}

//Package Commands
//add-migration MigrationName
//remove-migration
//update-database
//update-database -migration:0 -> go to migration 0
