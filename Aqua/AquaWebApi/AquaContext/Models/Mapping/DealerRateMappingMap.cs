using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class DealerRateMappingMap : EntityTypeConfiguration<DealerRateMapping>
    {
        public DealerRateMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DealerRateMappings");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.DealerFKID).HasColumnName("DealerFKID");
            this.Property(t => t.ProductFKID).HasColumnName("ProductFKID");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");

            // Relationships
            this.HasRequired(t => t.DealerMaster)
                .WithMany(t => t.DealerRateMappings)
                .HasForeignKey(d => d.DealerFKID);
            this.HasRequired(t => t.ProductMaster)
                .WithMany(t => t.DealerRateMappings)
                .HasForeignKey(d => d.ProductFKID);

        }
    }
}
