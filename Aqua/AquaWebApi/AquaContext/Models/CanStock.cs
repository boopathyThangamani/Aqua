using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class CanStock
    {
        public long PKID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public long DealerFKID { get; set; }
        public long ProductFKID { get; set; }
        public decimal Qty { get; set; }
        public bool IsInward { get; set; }
        public long BookingID { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public virtual DealerMaster DealerMaster { get; set; }
    }
}
