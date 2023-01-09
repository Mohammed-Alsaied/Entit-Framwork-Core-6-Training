namespace EF_Core_Many_to_Many_Relationship.Entities
{
    #region Composite Index Using Data Annotation
    //[Index(nameof(FirstName), nameof(LastName))]
    #endregion
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
