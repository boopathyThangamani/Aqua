using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class ProductMasterMap : EntityTypeConfiguration<ProductMaster>
    {
        public ProductMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Units)
                .HasMaxLength(50);

            this.Property(t => t.Code)
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("ProductMasters");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Units).HasColumnName("Units");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
            this.Property(t => t.IsCanType).HasColumnName("IsCanType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
        }
    }
}
