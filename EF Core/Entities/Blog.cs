namespace EF_Core.Entities
{
    public partial class Blog
    {
        public Blog()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        /// <summary>
        /// test comment
        /// </summary>
        public string Url { get; set; } = null!;
        public int Rating { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
