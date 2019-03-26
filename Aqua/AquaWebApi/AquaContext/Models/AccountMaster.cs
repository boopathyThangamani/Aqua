using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class AccountMaster
    {
        public AccountMaster()
        {
            this.Journals = new List<Journal>();
            this.Journals1 = new List<Journal>();
        }

        public long PKID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public decimal OpeningBalance { get; set; }
        public Nullable<long> AccountGroupFKID { get; set; }
        public long AccountTypeFKID { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public string OpeningBalanceType { get; set; }
        public virtual AccountGroupMaster AccountGroupMaster { get; set; }
        public virtual AccountTypeMaster AccountTypeMaster { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
        public virtual ICollection<Journal> Journals1 { get; set; }
    }
}
