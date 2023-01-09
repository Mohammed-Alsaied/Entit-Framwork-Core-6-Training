//namespace EFCore.Configurations
//{
//    public class BlogEntityTypeConfiguration : IEntityTypeConfiguration<Blog>
//    {
//        public void Configure(EntityTypeBuilder<Blog> builder)
//        {
//            #region Set Required Colomun

//            builder
//                .Property(b => b.Url)
//                .IsRequired();

//            #endregion 

//            #region Set MaxLength & Comment

//            builder.Property(b => b.Url)
//                .HasMaxLength(200)
//                .HasComment("test comment");

//            #endregion 

//            #region Set Default Value

//            builder.Property(b => b.Rating)
//                .HasDefaultValue(2);

//            #endregion

//            #region Set Default Value Sql

//            builder.Property(b => b.CreatedOn)
//                .HasDefaultValueSql("GETDATE()");
//            #endregion

//        }
//    }
//}