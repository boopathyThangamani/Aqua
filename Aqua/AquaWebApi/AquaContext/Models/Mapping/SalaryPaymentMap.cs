using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class SalaryPaymentMap : EntityTypeConfiguration<SalaryPayment>
    {
        public SalaryPaymentMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SalaryPayments");
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
            this.Property(t => t.IsCash).HasColumnName("IsCash");

            // Relationships
            this.HasRequired(t => t.UserMaster)
                .WithMany(t => t.SalaryPayments)
                .HasForeignKey(d => d.UserFKID);

        }
    }
}
