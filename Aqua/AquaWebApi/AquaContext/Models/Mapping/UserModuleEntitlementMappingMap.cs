using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class UserModuleEntitlementMappingMap : EntityTypeConfiguration<UserModuleEntitlementMapping>
    {
        public UserModuleEntitlementMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserModuleEntitlementMappings");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.UserFKID).HasColumnName("UserFKID");
            this.Property(t => t.ModuleFKID).HasColumnName("ModuleFKID");
            this.Property(t => t.IsReport).HasColumnName("IsReport");
            this.Property(t => t.HasView).HasColumnName("HasView");
            this.Property(t => t.HasCRUD).HasColumnName("HasCRUD");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");

            // Relationships
            this.HasRequired(t => t.ModuleReference)
                .WithMany(t => t.UserModuleEntitlementMappings)
                .HasForeignKey(d => d.ModuleFKID);
            this.HasRequired(t => t.UserMaster)
                .WithMany(t => t.UserModuleEntitlementMappings)
                .HasForeignKey(d => d.UserFKID);

        }
    }
}
