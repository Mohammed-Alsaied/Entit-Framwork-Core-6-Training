//namespace EFCore.Entities
//{
//    #region Execlud a class from Domain Model Uisng Data Annotaion

//    //[NotMapped]//1.Execlud a class from Domain Model Uisng Data Annotaion

//    #endregion Execlud a class from Domain Model Uisng Data Annotaion

//    public class Blog
//    {
//        public int ID { get; set; }

//        #region Change Property Name in DB using Data Annotations

//        //[Column("BlogUrl")]//1.Change property Name in DB using Data Annotations
//        //[Column(TypeName = "varchar(50)")]

//        #endregion Change Property Name in DB using Data Annotations

//        #region Change Property Type in DB using Data Annotations

//        //[Column(TypeName = "varchar(50)")]

//        #endregion Change Property Type in DB using Data Annotations

//        #region Set MaxLength by Data Annotations

//        //[MaxLength(200)]

//        #endregion Set MaxLength by Data Annotations

//        //[Comment("the url of the bog")]
//        public string Url { get; set; }

//        #region Change Property Type in DB using Data Annotations

//        //[Column(TypeName = "decimal(5,2)")]//1.Change property Type in DB using Data Annotations

//        #endregion Change Property Type in DB using Data Annotations

//        public int Rating { get; set; }

//        public DateTime CreatedOn { get; set; }

//        #region Execlud a Property from Domain Model Uisng Data Annotaion

//        //[NotMapped]
//        //public DateTime AddedOn { get; set; }//1.Execlud a property from Domain Model Uisng Data Annotaion

//        #endregion Execlud a Property from Domain Model Uisng Data Annotaion

//        #region Add Domain Model By using Navigation Propperty

//        public List<Post> Posts { get; set; }//Navigation Propperty ->//2.Add Domain Model

//        #endregion Add Domain Model By using Navigation Propperty
//    }
//}