using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class ModuleReferenceMap : EntityTypeConfiguration<ModuleReference>
    {
        public ModuleReferenceMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.ModuleCode)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.ModuleDescription)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RelatedTable)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ModuleReference");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.ModuleCode).HasColumnName("ModuleCode");
            this.Property(t => t.ModuleDescription).HasColumnName("ModuleDescription");
            this.Property(t => t.RelatedTable).HasColumnName("RelatedTable");
        }
    }
}
