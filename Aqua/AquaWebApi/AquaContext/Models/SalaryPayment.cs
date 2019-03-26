using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class SalaryPayment
    {
        public long PKID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public long UserFKID { get; set; }
        public decimal Amount { get; set; }
        public long JournalFKID { get; set; }
        public System.DateTime Date { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public virtual UserMaster UserMaster { get; set; }
        public Boolean IsCash { get; set; }
    }
}
