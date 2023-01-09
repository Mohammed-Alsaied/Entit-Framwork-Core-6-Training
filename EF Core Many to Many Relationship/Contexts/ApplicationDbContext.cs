namespace EFCore_Relationships.Contexts
{
    public partial class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore Relationships ;Integrated Security=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Many to many Relation using Fluent Api
            //modelBuilder.Entity<Post>()
            //    .HasMany(p => p.Tags)
            //    .WithMany(t => t.Posts)
            //    .UsingEntity(j => j.ToTable("PostTagsTest"));
            #endregion

            #region Many to many Relation Full Configuration using Fluent Api
            //modelBuilder.Entity<Post>()
            //    .HasMany(p => p.Tags)
            //    .WithMany(t => t.Posts)
            //    .UsingEntity<PostTag>(
            //        t => t
            //            .HasOne(pt => pt.Tag)
            //            .WithMany(t => t.PostTags)
            //            .HasForeignKey(pt => pt.TagId),
            //        p => p
            //            .HasOne(pt => pt.Post)
            //            .WithMany(t => t.PostTags)
            //            .HasForeignKey(pt => pt.PostId),
            //        j =>
            //        {
            //            j.Property(pt => pt.AddedOn).HasDefaultValueSql("GETDATE()");
            //            j.HasKey(k => new { k.TagId, k.PostId });//Composite Key
            //        }
            //        );
            #endregion

            #region Indirect Many To Many Relationship
            //modelBuilder.Entity<PostTag>()
            //    .HasKey(k => new { k.PostId, k.TagId });

            //modelBuilder.Entity<PostTag>()
            //    .HasOne(p => p.Post)
            //    .WithMany(p => p.PostTags)
            //    .HasForeignKey(p => p.PostId);

            //modelBuilder.Entity<PostTag>()
            //    .HasOne(p => p.Tag)
            //    .WithMany(p => p.PostTags)
            //    .HasForeignKey(p => p.TagId);
            #endregion

            #region Index using Fluent Api
            //modelBuilder.Entity<Post>()
            //    .HasIndex(p => p.Title);
            #endregion

            #region Composite Index Using Fluent Api
            //modelBuilder.Entity<Person>()
            //    .HasIndex(i => new { i.FirstName, i.LastName });
            #endregion

            #region Uniqe Index using Fluent Api
            //modelBuilder.Entity<Post>()
            //    .HasIndex(p => p.Title)
            //    .IsUnique();
            #endregion

            #region Naming of Index using Fluent Api
            //modelBuilder.Entity<Post>()
            //.HasIndex(p => p.Title)
            //.HasDatabaseName("Index_Title_Test");
            #endregion

            #region Index Filter using Fluent Api
            //modelBuilder.Entity<Post>()
            //.HasIndex(p => p.Title)
            //.HasFilter("[Title] IS NOT NULL");//SQL SYntax
            #endregion

            #region Index Filter Null using Fluent Api
            //modelBuilder.Entity<Post>()
            //.HasIndex(p => p.Title)
            //.IsUnique()
            //.HasFilter(null);//SQL SYntax
            #endregion

            #region Sequence Using Fluent Api
            //modelBuilder.HasSequence<int>("OrderNumber", schema: "shared")
            //    .StartsAt(1000)
            //    .IncrementsBy(5);

            //modelBuilder.Entity<Order>()
            //    .Property(o => o.OrderNo)
            //    .HasDefaultValueSql("NEXT VALUE FOR shared.OrderNumber");

            //modelBuilder.Entity<OrderTest>()
            //    .Property(o => o.OrderNo)
            //    .HasDefaultValueSql("NEXT VALUE FOR shared.OrderNumber");
            #endregion

            #region Data Seeding
            modelBuilder.Entity<Post>()
                .HasData(new Post { PostId = 1, Title = "Post1", Content = "post post1" },
                new Post { PostId = 2, Title = "Post2", Content = "post post2" });

            //modelBuilder.Entity<Post>()
            //   .HasData(new Post { PostId = 2, Title = "Post2", Content = "post post2" });

            modelBuilder.Entity<Tag>()
               .HasData(new Tag { TagId = "1", });
            #endregion
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        //public DbSet<PostTag> PostTags { get; set; }
        //public DbSet<Person> Persons { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderTest> OrdersTest { get; set; }
    }
}