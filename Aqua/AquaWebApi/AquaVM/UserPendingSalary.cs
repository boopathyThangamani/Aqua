using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVM
{
    public class UserPendingSalary
    {
        public Int64 UserID { get; set; }
        public string UserName { get; set; }
        public string Department { get; set; }
        public Int64 AccountID { get; set; }
        public decimal OpeningBalance { get; set; }
        public Int64 OpeningBalanceType { get; set; }
        public DateTime OpeningBalanceDate { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get; set; }

    }
}
