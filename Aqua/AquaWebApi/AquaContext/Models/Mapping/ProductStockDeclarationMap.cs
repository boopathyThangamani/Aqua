using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class ProductStockDeclarationMap : EntityTypeConfiguration<ProductStockDeclaration>
    {
        public ProductStockDeclarationMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProductStockDeclaration");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDatetime).HasColumnName("CreatedDatetime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDatetime).HasColumnName("ModifiedDatetime");
        }
    }
}
