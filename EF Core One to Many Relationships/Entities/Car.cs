namespace EFCore_One_to_Many_Relationships.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public string State { get; set; }

        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public List<RecordOfSale> SaleHistory { get; set; }

    }
}
