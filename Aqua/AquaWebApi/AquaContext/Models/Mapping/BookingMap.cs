using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class BookingMap : EntityTypeConfiguration<Booking>
    {
        public BookingMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.DeliveryAddress)
                .HasMaxLength(1000);

            this.Property(t => t.BillNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Bookings");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.DealerFKID).HasColumnName("DealerFKID");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");
            this.Property(t => t.IsDeliveryRequired).HasColumnName("IsDeliveryRequired");
            this.Property(t => t.DeliveryDateTime).HasColumnName("DeliveryDateTime");
            this.Property(t => t.IsDelivered).HasColumnName("IsDelivered");
            this.Property(t => t.DeliveryAddress).HasColumnName("DeliveryAddress");
            this.Property(t => t.IsFreightRequired).HasColumnName("IsFreightRequired");
            this.Property(t => t.FreightAmount).HasColumnName("FreightAmount");
            this.Property(t => t.IsFreightBorneByUs).HasColumnName("IsFreightBorneByUs");
            this.Property(t => t.IsFreightPaidByUs).HasColumnName("IsFreightPaidByUs");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
            this.Property(t => t.BillNo).HasColumnName("BillNo");

            // Relationships
            this.HasOptional(t => t.DealerMaster)
                .WithMany(t => t.Bookings)
                .HasForeignKey(d => d.DealerFKID);

        }
    }
}
