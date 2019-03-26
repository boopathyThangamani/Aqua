using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class PurchaseOrderDetail
    {
        public long PKID { get; set; }
        public long HeaderFKID { get; set; }
        public long RMFKID { get; set; }
        public decimal Qty { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<bool> IsFullyReceived { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual RawMaterialMaster RawMaterialMaster { get; set; }
    }
}
