using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVM
{
    public class SalaryPaymentVM
    {
        public long PKID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public long UserFKID { get; set; }
        public string UserName { get; set; }
        public Nullable<long> UserAccountFKID { get; set; }
        public decimal Amount { get; set; }
        public long JournalFKID { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public int isCash { get; set; }
        public string Department { get; set; }
        public decimal OpeningBalance { get; set; }
        public Int64 OpeningBalanceType { get; set; }
        public DateTime? OpeningBalanceDate { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get; set; }

    }
}
