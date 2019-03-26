using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class DealerMaster
    {
        public DealerMaster()
        {
            this.Bookings = new List<Booking>();
            this.CanStocks = new List<CanStock>();
            this.DealerRateMappings = new List<DealerRateMapping>();
        }

        public long PKID { get; set; }
        public string DealerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactPersonName { get; set; }
        public Nullable<long> AccountFKID { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public Nullable<long> OpeningBalanceType { get; set; }
        public Nullable<System.DateTime> OpenningBalanceDate { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public string MobileNumber { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<CanStock> CanStocks { get; set; }
        public virtual ICollection<DealerRateMapping> DealerRateMappings { get; set; }
    }
}
