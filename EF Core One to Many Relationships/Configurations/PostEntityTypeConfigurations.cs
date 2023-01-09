

namespace EFCore_One_to_Many_Relationships.Configurations
{
    public class PostEntityTypeConfigurations : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            #region One to Many RelationShip
            //builder.HasOne(b => b.Blog)
            //    .WithMany(b => b.Posts);

            builder.HasOne<Blog>()
                .WithMany()
                .HasForeignKey(p => p.BlogId)
                .HasConstraintName("FK_Posts_Test");
            #endregion
        }
    }
}
