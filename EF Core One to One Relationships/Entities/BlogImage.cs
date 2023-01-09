namespace EFCore_Relationships.Entities
{
    public class BlogImage //Dependengt Entity
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Caption { get; set; }

        //[ForeignKey("BlogForeignKey")]
        public int BlogId { get; set; }

        public Blog Blog { get; set; }
    }
}
