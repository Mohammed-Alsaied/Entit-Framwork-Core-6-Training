

namespace EFCore_Relationships.Configurations
{
    public class BlogImageEntityTypeConfiguration : IEntityTypeConfiguration<BlogImage>
    {
        public void Configure(EntityTypeBuilder<BlogImage> builder)
        {
            builder.Property(b => b.Caption)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
