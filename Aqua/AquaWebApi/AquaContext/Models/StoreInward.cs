using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class StoreInward
    {
        public StoreInward()
        {
            this.StoreInwardDetails = new List<StoreInwardDetail>();
        }

        public long PKID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public bool IsFreightRequired { get; set; }
        public decimal FreightAmount { get; set; }
        public bool IsFreightBorneByUs { get; set; }
        public Nullable<bool> IsFreightPaidByUs { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDatetime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public long SupplierFKID { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public virtual ICollection<StoreInwardDetail> StoreInwardDetails { get; set; }
        public virtual SupplierMaster SupplierMaster { get; set; }
    }
}
