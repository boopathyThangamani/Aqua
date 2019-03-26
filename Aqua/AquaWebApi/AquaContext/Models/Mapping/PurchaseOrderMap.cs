using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class PurchaseOrderMap : EntityTypeConfiguration<PurchaseOrder>
    {
        public PurchaseOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PurchaseOrder");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.SupplierFKID).HasColumnName("SupplierFKID");
            this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.IsFullyReceived).HasColumnName("IsFullyReceived");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
        }
    }
}
