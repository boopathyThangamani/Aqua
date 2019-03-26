using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class JournalHistoryMap : EntityTypeConfiguration<JournalHistory>
    {
        public JournalHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.PKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comments)
                .HasMaxLength(1000);

            this.Property(t => t.ModuleCode)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("JournalHistory");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.DebitACFKID).HasColumnName("DebitACFKID");
            this.Property(t => t.CreditACFKID).HasColumnName("CreditACFKID");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.ModuleCode).HasColumnName("ModuleCode");
            this.Property(t => t.ReferenceID).HasColumnName("ReferenceID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
        }
    }
}
