using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class AccountMasterMap : EntityTypeConfiguration<AccountMaster>
    {
        public AccountMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OpeningBalanceType)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("AccountMasters");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.OpeningBalance).HasColumnName("OpeningBalance");
            this.Property(t => t.AccountGroupFKID).HasColumnName("AccountGroupFKID");
            this.Property(t => t.AccountTypeFKID).HasColumnName("AccountTypeFKID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
            this.Property(t => t.OpeningBalanceType).HasColumnName("OpeningBalanceType");

            // Relationships
            this.HasOptional(t => t.AccountGroupMaster)
                .WithMany(t => t.AccountMasters)
                .HasForeignKey(d => d.AccountGroupFKID);
            this.HasRequired(t => t.AccountTypeMaster)
                .WithMany(t => t.AccountMasters)
                .HasForeignKey(d => d.AccountTypeFKID);

        }
    }
}
