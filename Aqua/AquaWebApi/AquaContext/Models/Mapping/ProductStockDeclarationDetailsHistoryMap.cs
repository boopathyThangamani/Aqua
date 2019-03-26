using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class ProductStockDeclarationDetailsHistoryMap : EntityTypeConfiguration<ProductStockDeclarationDetailsHistory>
    {
        public ProductStockDeclarationDetailsHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.PKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ProductStockDeclarationDetailsHistory");
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
        }
    }
}
