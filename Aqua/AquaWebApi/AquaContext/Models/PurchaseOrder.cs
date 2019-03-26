using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            this.PurchaseOrderDetails = new List<PurchaseOrderDetail>();
        }

        public long PKID { get; set; }
        public long SupplierFKID { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> IsFullyReceived { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
