

namespace EFCore_Relationships.Configurations
{
    public class BlogEntityTypeConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(b => b.Url)
                .HasMaxLength(1000)
                .IsRequired();

            #region One To One Relationship by Fluent API
            builder.HasOne(b => b.BLogImage)
                .WithOne(b => b.Blog)
                .HasForeignKey<BlogImage>(b => b.BlogId);
            #endregion
        }
    }
}
