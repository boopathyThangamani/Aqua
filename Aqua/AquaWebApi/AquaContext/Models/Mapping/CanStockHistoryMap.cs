using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class CanStockHistoryMap : EntityTypeConfiguration<CanStockHistory>
    {
        public CanStockHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.PKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CanStockHistory");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.DealerFKID).HasColumnName("DealerFKID");
            this.Property(t => t.ProductFKID).HasColumnName("ProductFKID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.IsInward).HasColumnName("IsInward");
            this.Property(t => t.BookingID).HasColumnName("BookingID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
        }
    }
}
