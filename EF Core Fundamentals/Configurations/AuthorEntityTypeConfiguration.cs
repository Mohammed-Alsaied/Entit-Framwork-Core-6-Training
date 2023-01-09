//namespace EFCore.Configurations
//{
//    public class AuthorEntityTypeConfiguration : IEntityTypeConfiguration<Author>
//    {
//        public void Configure(EntityTypeBuilder<Author> builder)
//        {
//            #region Set Computed Column
//            builder.Property(a => a.DisplayName)
//                .HasComputedColumnSql("[LastName] + ',' + [FirstName]");
//            #endregion
//        }
//    }
//}
