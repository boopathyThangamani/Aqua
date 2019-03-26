using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class StockDeclarationDetail
    {
        public long PKID { get; set; }
        public long StockDeclarationFKID { get; set; }
        public long RMID { get; set; }
        public decimal OpeningStock { get; set; }
        public decimal Consumed { get; set; }
        public decimal Inward { get; set; }
        public decimal Damaged { get; set; }
        public decimal ClosingStock { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDatetime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDatetime { get; set; }
        public virtual StockDeclaration StockDeclaration { get; set; }
    }
}
