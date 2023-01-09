namespace EF_Core_Many_to_Many_Relationship.Entities
{
    public class PostTag
    {
        public int PostId { get; set; }
        public Post Post { get; set; }

        public string TagId { get; set; }
        public Tag Tag { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
