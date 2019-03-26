using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class SupplierMaster
    {
        public SupplierMaster()
        {
            this.StoreInwards = new List<StoreInward>();
            this.SupplierRawMaterialMappings = new List<SupplierRawMaterialMapping>();
        }

        public long PKID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PAN { get; set; }
        public string TIN { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public Nullable<long> AccountFKID { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public Nullable<long> OpeningBalanceType { get; set; }
        public Nullable<System.DateTime> OpenningBalanceDate { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public virtual ICollection<StoreInward> StoreInwards { get; set; }
        public virtual ICollection<SupplierRawMaterialMapping> SupplierRawMaterialMappings { get; set; }
    }
}
