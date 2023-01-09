//namespace EFCore.Configurations
//{
//    public class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
//    {
//        public void Configure(EntityTypeBuilder<Book> builder)
//        {
//            #region Primary Key & Change his Name

//            builder.HasKey(b => b.BookKey)
//                .HasName("PK_Book_Key");

//            #endregion Primary Key & Change his Name

//            #region Composite Key

//            builder.HasKey(b => new { b.Name, b.Author });

//            #endregion Composite Key
//        }
//    }
//}