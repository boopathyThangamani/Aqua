using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class DealerRateMapping
    {
        public long PKID { get; set; }
        public long DealerFKID { get; set; }
        public long ProductFKID { get; set; }
        public decimal Rate { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public virtual DealerMaster DealerMaster { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
    }
}
