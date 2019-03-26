using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class UserMasterMap : EntityTypeConfiguration<UserMaster>
    {
        public UserMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(500);

            this.Property(t => t.Mobile)
                .HasMaxLength(50);

            this.Property(t => t.Designation)
                .HasMaxLength(50);

            this.Property(t => t.LoginID)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(8000);

            this.Property((t => t.OpeningBalanceType))
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("UserMasters");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.DOJ).HasColumnName("DOJ");
            this.Property(t => t.DOB).HasColumnName("DOB");
            this.Property(t => t.DOR).HasColumnName("DOR");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.Admin).HasColumnName("Admin");
            this.Property(t => t.Designation).HasColumnName("Designation");
            this.Property(t => t.DepartmentFKID).HasColumnName("DepartmentFKID");
            this.Property(t => t.LoginID).HasColumnName("LoginID");
            this.Property(t => t.HasLogin).HasColumnName("HasLogin");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.AccountFKID).HasColumnName("AccountFKID");
            this.Property(t => t.OpeningBalance).HasColumnName("OpeningBalance");
            this.Property(t => t.OpeningBalanceType).HasColumnName("OpeningBalanceType");
            this.Property(t => t.OpeningBalanceDate).HasColumnName("OpeningBalanceDate");

            // Relationships
            this.HasOptional(t => t.DepartmentMaster)
                .WithMany(t => t.UserMasters)
                .HasForeignKey(d => d.DepartmentFKID);

        }
    }
}
