using Microsoft.EntityFrameworkCore;

namespace Datebase_Scaffolding.Entities
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BlogImage> BlogImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=EFCore Relationships");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<BlogImage>(entity =>
            {
                entity.HasIndex(e => e.BlogId, "IX_BlogImages_BlogId")
                    .IsUnique();

                entity.Property(e => e.Caption).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.HasOne(d => d.Blog)
                    .WithOne(p => p.BlogImage)
                    .HasForeignKey<BlogImage>(d => d.BlogId);
            });

            modelBuilder.HasSequence<int>("OrderNumber");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
