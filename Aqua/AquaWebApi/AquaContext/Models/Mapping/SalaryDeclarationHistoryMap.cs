using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class SalaryDeclarationHistoryMap : EntityTypeConfiguration<SalaryDeclarationHistory>
    {
        public SalaryDeclarationHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.PKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Month)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SalaryDeclarationHistory");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.UserFKID).HasColumnName("UserFKID");
            this.Property(t => t.Month).HasColumnName("Month");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.JournalFKID).HasColumnName("JournalFKID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
        }
    }
}
