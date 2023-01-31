namespace EF_Core.Entities
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        //public Author Author { get; set; } = null!;
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
