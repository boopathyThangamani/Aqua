using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class SalaryDeclarationHistory
    {
        public long PKID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public long UserFKID { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public decimal Amount { get; set; }
        public long JournalFKID { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
    }
}
