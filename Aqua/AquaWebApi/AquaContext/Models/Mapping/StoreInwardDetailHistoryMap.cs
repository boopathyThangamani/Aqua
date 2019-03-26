using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AquaContext.Mapping
{
    public class StoreInwardDetailHistoryMap : EntityTypeConfiguration<StoreInwardDetailHistory>
    {
        public StoreInwardDetailHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.PKID);

            // Properties
            this.Property(t => t.PKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("StoreInwardDetailHistory");
            this.Property(t => t.PKID).HasColumnName("PKID");
            this.Property(t => t.StoreInwardFKID).HasColumnName("StoreInwardFKID");
            this.Property(t => t.PODetailFKID).HasColumnName("PODetailFKID");
            this.Property(t => t.RMFKID).HasColumnName("RMFKID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDatetime).HasColumnName("CreatedDatetime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
        }
    }
}
