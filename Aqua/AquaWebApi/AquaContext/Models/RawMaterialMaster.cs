using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class RawMaterialMaster
    {
        public RawMaterialMaster()
        {
            this.PurchaseOrderDetails = new List<PurchaseOrderDetail>();
            this.SupplierRawMaterialMappings = new List<SupplierRawMaterialMapping>();
        }

        public long PKID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Units { get; set; }
        public decimal ROL { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<bool> AlertFlag { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual ICollection<SupplierRawMaterialMapping> SupplierRawMaterialMappings { get; set; }
    }
}
