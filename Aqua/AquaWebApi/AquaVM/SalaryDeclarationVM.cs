using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVM
{
    public class SalaryDeclarationVM
    {
        public long PKID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public long UserFKID { get; set; }
        public string UserName { get; set; }
        public Nullable<long> UserAccountFKID { get; set; }
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
