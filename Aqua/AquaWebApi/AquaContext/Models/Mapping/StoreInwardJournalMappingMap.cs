using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class StoreInwardJournalMappingMap : EntityTypeConfiguration<StoreInwardJournalMapping>
    {
        public StoreInwardJournalMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("StoreInwardJournalMapping");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.StoreInwardFKID).HasColumnName("StoreInwardFKID");
            this.Property(t => t.JournalFKID).HasColumnName("JournalFKID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDatetime).HasColumnName("CreatedDatetime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDatetime).HasColumnName("ModifiedDatetime");

            // Relationships
            this.HasRequired(t => t.Journal)
                .WithMany(t => t.StoreInwardJournalMappings)
                .HasForeignKey(d => d.JournalFKID);

        }
    }
}
