using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class BookingDetail
    {
        public long PKID { get; set; }
        public long BookingFKID { get; set; }
        public long ProductFKID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> FreeQty { get; set; }
        public Nullable<decimal> DamageQty { get; set; }
        public Nullable<decimal> TotalQty { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
    }
}
