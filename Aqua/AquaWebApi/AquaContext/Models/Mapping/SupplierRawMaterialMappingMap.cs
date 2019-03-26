using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class SupplierRawMaterialMappingMap : EntityTypeConfiguration<SupplierRawMaterialMapping>
    {
        public SupplierRawMaterialMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SupplierRawMaterialMappings");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.SuppllierFKID).HasColumnName("SuppllierFKID");
            this.Property(t => t.RMFKID).HasColumnName("RMFKID");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");

            // Relationships
            this.HasRequired(t => t.RawMaterialMaster)
                .WithMany(t => t.SupplierRawMaterialMappings)
                .HasForeignKey(d => d.RMFKID);
            this.HasRequired(t => t.SupplierMaster)
                .WithMany(t => t.SupplierRawMaterialMappings)
                .HasForeignKey(d => d.SuppllierFKID);

        }
    }
}
