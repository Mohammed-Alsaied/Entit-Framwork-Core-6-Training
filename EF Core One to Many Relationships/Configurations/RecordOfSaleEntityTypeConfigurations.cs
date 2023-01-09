namespace EFCore_One_to_Many_Relationships.Configurations
{
    public class RecordOfSaleEntityTypeConfigurations : IEntityTypeConfiguration<RecordOfSale>
    {
        public void Configure(EntityTypeBuilder<RecordOfSale> builder)
        {
            //builder.HasOne(s => s.Car)
            //    .WithMany(c => c.SaleHistory)
            //    .HasForeignKey(p => p.CarLicensePlate)
            //    .HasPrincipalKey(c => c.LicensePlate);

            builder.HasOne(s => s.Car)
                .WithMany(c => c.SaleHistory)
                .HasForeignKey(s => new { s.CarLicensePlate, s.CarState })
                .HasPrincipalKey(c => new { c.LicensePlate, c.State });
        }
    }
}
