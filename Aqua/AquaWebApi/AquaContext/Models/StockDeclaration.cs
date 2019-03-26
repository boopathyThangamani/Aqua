using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class StockDeclaration
    {
        public StockDeclaration()
        {
            this.StockDeclarationDetails = new List<StockDeclarationDetail>();
        }

        public long PKID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDatetime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDatetime { get; set; }
        public virtual ICollection<StockDeclarationDetail> StockDeclarationDetails { get; set; }
    }
}
