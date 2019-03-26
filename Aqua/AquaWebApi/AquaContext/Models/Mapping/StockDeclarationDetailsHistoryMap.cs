using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class StockDeclarationDetailsHistoryMap : EntityTypeConfiguration<StockDeclarationDetailsHistory>
    {
        public StockDeclarationDetailsHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.PKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("StockDeclarationDetailsHistory");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.StockDeclarationFKID).HasColumnName("StockDeclarationFKID");
            this.Property(t => t.RMID).HasColumnName("RMID");
            this.Property(t => t.OpeningStock).HasColumnName("OpeningStock");
            this.Property(t => t.Consumed).HasColumnName("Consumed");
            this.Property(t => t.Inward).HasColumnName("Inward");
            this.Property(t => t.Damaged).HasColumnName("Damaged");
            this.Property(t => t.ClosingStock).HasColumnName("ClosingStock");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDatetime).HasColumnName("CreatedDatetime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDatetime).HasColumnName("ModifiedDatetime");
        }
    }
}
