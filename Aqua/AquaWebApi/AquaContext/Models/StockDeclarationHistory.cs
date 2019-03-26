using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class StockDeclarationHistory
    {
        public long PKID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDatetime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDatetime { get; set; }
    }
}
