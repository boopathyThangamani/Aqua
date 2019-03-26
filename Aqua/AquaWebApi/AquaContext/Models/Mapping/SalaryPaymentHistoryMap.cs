using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class SalaryPaymentHistoryMap : EntityTypeConfiguration<SalaryPaymentHistory>
    {
        public SalaryPaymentHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.PKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SalaryPaymentHistory");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.UserFKID).HasColumnName("UserFKID");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.JournalFKID).HasColumnName("JournalFKID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
        }
    }
}
