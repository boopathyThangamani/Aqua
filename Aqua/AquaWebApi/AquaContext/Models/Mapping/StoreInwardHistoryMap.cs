using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class StoreInwardHistoryMap : EntityTypeConfiguration<StoreInwardHistory>
    {
        public StoreInwardHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PKID, t.TransactionDate, t.IsFreightRequired, t.FreightAmount, t.IsFreightBorneByUs, t.CreatedBy, t.CreatedDatetime, t.SupplierFKID });

            // Properties
            this.Property(t => t.PKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FreightAmount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreatedBy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SupplierFKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("StoreInwardHistory");
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
        }
    }
}
