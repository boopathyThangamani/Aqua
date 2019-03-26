using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class PurchaseOrderDetailMap : EntityTypeConfiguration<PurchaseOrderDetail>
    {
        public PurchaseOrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PurchaseOrderDetails");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.HeaderFKID).HasColumnName("HeaderFKID");
            this.Property(t => t.RMFKID).HasColumnName("RMFKID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.IsFullyReceived).HasColumnName("IsFullyReceived");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
            this.Property(t => t.Amount).HasColumnName("Amount");

            // Relationships
            this.HasRequired(t => t.PurchaseOrder)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.HeaderFKID);
            this.HasRequired(t => t.RawMaterialMaster)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.RMFKID);

        }
    }
}
