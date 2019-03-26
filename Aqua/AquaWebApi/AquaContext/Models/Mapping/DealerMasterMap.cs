using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class DealerMasterMap : EntityTypeConfiguration<DealerMaster>
    {
        public DealerMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.DealerName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(500);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(12);

            this.Property(t => t.ContactPersonName)
                .HasMaxLength(50);

            this.Property(t => t.MobileNumber)
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("DealerMasters");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.DealerName).HasColumnName("DealerName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.ContactPersonName).HasColumnName("ContactPersonName");
            this.Property(t => t.AccountFKID).HasColumnName("AccountFKID");
            this.Property(t => t.OpeningBalance).HasColumnName("OpeningBalance");
            this.Property(t => t.OpeningBalanceType).HasColumnName("OpeningBalanceType");
            this.Property(t => t.OpenningBalanceDate).HasColumnName("OpenningBalanceDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
            this.Property(t => t.MobileNumber).HasColumnName("MobileNumber");
        }
    }
}
