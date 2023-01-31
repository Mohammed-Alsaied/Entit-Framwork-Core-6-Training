namespace EF_Core.Entities
{
    public partial class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int NationalityId { get; set; }
        public Nationalities Nationalities { get; set; }

    }
}
