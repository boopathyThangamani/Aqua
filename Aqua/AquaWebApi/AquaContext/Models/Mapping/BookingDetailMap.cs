using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class BookingDetailMap : EntityTypeConfiguration<BookingDetail>
    {
        public BookingDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BookingDetails");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.BookingFKID).HasColumnName("BookingFKID");
            this.Property(t => t.ProductFKID).HasColumnName("ProductFKID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.FreeQty).HasColumnName("FreeQty");
            this.Property(t => t.DamageQty).HasColumnName("DamageQty");
            this.Property(t => t.TotalQty).HasColumnName("TotalQty");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");

            // Relationships
            this.HasRequired(t => t.Booking)
                .WithMany(t => t.BookingDetails)
                .HasForeignKey(d => d.BookingFKID);
            this.HasRequired(t => t.ProductMaster)
                .WithMany(t => t.BookingDetails)
                .HasForeignKey(d => d.ProductFKID);

        }
    }
}
