using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class SupplierRawMaterialMapping
    {
        public long PKID { get; set; }
        public long SuppllierFKID { get; set; }
        public long RMFKID { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public virtual RawMaterialMaster RawMaterialMaster { get; set; }
        public virtual SupplierMaster SupplierMaster { get; set; }
    }
}
