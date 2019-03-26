using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class StoreInwardMap : EntityTypeConfiguration<StoreInward>
    {
        public StoreInwardMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("StoreInwards");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.IsFreightRequired).HasColumnName("IsFreightRequired");
            this.Property(t => t.FreightAmount).HasColumnName("FreightAmount");
            this.Property(t => t.IsFreightBorneByUs).HasColumnName("IsFreightBorneByUs");
            this.Property(t => t.IsFreightPaidByUs).HasColumnName("IsFreightPaidByUs");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDatetime).HasColumnName("CreatedDatetime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
            this.Property(t => t.SupplierFKID).HasColumnName("SupplierFKID");
            this.Property(t => t.TaxAmount).HasColumnName("TaxAmount");
            this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");

            // Relationships
            this.HasRequired(t => t.SupplierMaster)
                .WithMany(t => t.StoreInwards)
                .HasForeignKey(d => d.SupplierFKID);

        }
    }
}
