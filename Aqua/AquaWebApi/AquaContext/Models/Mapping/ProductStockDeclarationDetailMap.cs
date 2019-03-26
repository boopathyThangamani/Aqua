using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class ProductStockDeclarationDetailMap : EntityTypeConfiguration<ProductStockDeclarationDetail>
    {
        public ProductStockDeclarationDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProductStockDeclarationDetails");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.ProductStockDeclarationFKID).HasColumnName("ProductStockDeclarationFKID");
            this.Property(t => t.ProductFKID).HasColumnName("ProductFKID");
            this.Property(t => t.OpeningStock).HasColumnName("OpeningStock");
            this.Property(t => t.ManufacturedQty).HasColumnName("ManufacturedQty");
            this.Property(t => t.Sales).HasColumnName("Sales");
            this.Property(t => t.SalesReturn).HasColumnName("SalesReturn");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDatetime).HasColumnName("CreatedDatetime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDatetime).HasColumnName("ModifiedDatetime");
            this.Property(t => t.ClosingStock).HasColumnName("ClosingStock");

            // Relationships
            this.HasRequired(t => t.ProductStockDeclaration)
                .WithMany(t => t.ProductStockDeclarationDetails)
                .HasForeignKey(d => d.ProductStockDeclarationFKID);

        }
    }
}
