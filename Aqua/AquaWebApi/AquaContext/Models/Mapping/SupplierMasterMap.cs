using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class SupplierMasterMap : EntityTypeConfiguration<SupplierMaster>
    {
        public SupplierMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(500);

            this.Property(t => t.PAN)
                .HasMaxLength(50);

            this.Property(t => t.TIN)
                .HasMaxLength(50);

            this.Property(t => t.Mobile)
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SupplierMasters");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.PAN).HasColumnName("PAN");
            this.Property(t => t.TIN).HasColumnName("TIN");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.AccountFKID).HasColumnName("AccountFKID");
            this.Property(t => t.OpeningBalance).HasColumnName("OpeningBalance");
            this.Property(t => t.OpeningBalanceType).HasColumnName("OpeningBalanceType");
            this.Property(t => t.OpenningBalanceDate).HasColumnName("OpenningBalanceDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
        }
    }
}
