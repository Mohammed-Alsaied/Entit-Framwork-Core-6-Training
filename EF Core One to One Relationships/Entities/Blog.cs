

namespace EFCore.Entities
{


    public class Blog //Principal Entity
    {
        public int Id { get; set; }
        [Required, MaxLength(1000)]
        public string Url { get; set; }

        public BlogImage BLogImage { get; set; }



    }
}