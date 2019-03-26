using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class JournalHistory
    {
        public long PKID { get; set; }
        public System.DateTime Date { get; set; }
        public long DebitACFKID { get; set; }
        public long CreditACFKID { get; set; }
        public decimal Amount { get; set; }
        public string Comments { get; set; }
        public string ModuleCode { get; set; }
        public Nullable<long> ReferenceID { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
    }
}
