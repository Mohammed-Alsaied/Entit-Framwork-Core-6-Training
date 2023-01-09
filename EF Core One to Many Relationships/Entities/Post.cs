namespace EFCore_One_to_Many_Relationships.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; } //shadow ForeignKey

        //public Blog Blog { get; set; }
    }
}
