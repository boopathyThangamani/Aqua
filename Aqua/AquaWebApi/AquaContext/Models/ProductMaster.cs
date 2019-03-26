using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class ProductMaster
    {
        public ProductMaster()
        {
            this.BookingDetails = new List<BookingDetail>();
            this.DealerRateMappings = new List<DealerRateMapping>();
        }

        public long PKID { get; set; }
        public string Name { get; set; }
        public string Units { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public Nullable<bool> IsCanType { get; set; }
        public string Code { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual ICollection<DealerRateMapping> DealerRateMappings { get; set; }
    }
}
