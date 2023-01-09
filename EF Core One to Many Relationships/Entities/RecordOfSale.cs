namespace EFCore_One_to_Many_Relationships.Entities
{
    public class RecordOfSale
    {
        public int RecordOfSaleId { get; set; }
        public DateTime DateSold { get; set; }

        public decimal Price { get; set; }

        public string CarState { get; set; }

        public string CarLicensePlate { get; set; }

        public Car Car { get; set; }
    }
}
