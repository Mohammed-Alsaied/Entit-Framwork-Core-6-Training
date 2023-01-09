namespace EFCore_One_to_Many_Relationships.Configurations
{
    public class BlogEntityTypeConfigurations : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            #region One to Many RelationShip

            //builder.HasMany(b => b.Posts)
            //    .WithOne();
            #endregion



        }
    }
}
