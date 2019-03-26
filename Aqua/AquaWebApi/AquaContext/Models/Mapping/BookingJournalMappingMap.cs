using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class BookingJournalMappingMap : EntityTypeConfiguration<BookingJournalMapping>
    {
        public BookingJournalMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BookingJournalMapping");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.BookingsFKID).HasColumnName("BookingsFKID");
            this.Property(t => t.JournalFKID).HasColumnName("JournalFKID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDatetime).HasColumnName("CreatedDatetime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDatetime).HasColumnName("ModifiedDatetime");

            // Relationships
            this.HasRequired(t => t.Journal)
                .WithMany(t => t.BookingJournalMappings)
                .HasForeignKey(d => d.JournalFKID);

        }
    }
}
