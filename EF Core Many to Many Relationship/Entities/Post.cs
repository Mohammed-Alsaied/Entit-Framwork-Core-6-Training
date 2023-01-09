namespace EF_Core_Many_to_Many_Relationship.Entities
{
    #region Index using Data Annotation
    //[Index(nameof(Title))]
    #endregion

    #region Uniqe Index using Data Annotation
    //[Index(nameof(Title), IsUnique = true)]
    #endregion

    #region Naming of Index using Data Annotation
    //[Index(nameof(Title), Name = "Index_Title")]
    #endregion

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //public ICollection<Tag> Tags { get; set; }
        //public List<PostTag> PostTags { get; set; }

    }
}