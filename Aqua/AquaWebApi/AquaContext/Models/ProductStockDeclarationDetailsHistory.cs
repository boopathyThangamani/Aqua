using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class ProductStockDeclarationDetailsHistory
    {
        public long PKID { get; set; }
        public long ProductStockDeclarationFKID { get; set; }
        public long ProductFKID { get; set; }
        public decimal OpeningStock { get; set; }
        public decimal ManufacturedQty { get; set; }
        public decimal Sales { get; set; }
        public decimal SalesReturn { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDatetime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDatetime { get; set; }
        public Nullable<decimal> ClosingStock { get; set; }
    }
}
