using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class StoreInwardDetailHistory
    {
        public long PKID { get; set; }
        public long StoreInwardFKID { get; set; }
        public Nullable<long> PODetailFKID { get; set; }
        public long RMFKID { get; set; }
        public decimal Qty { get; set; }
        public System.DateTime Date { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDatetime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
    }
}
