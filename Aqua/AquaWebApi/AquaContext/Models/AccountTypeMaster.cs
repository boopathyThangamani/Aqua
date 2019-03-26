using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class AccountTypeMaster
    {
        public AccountTypeMaster()
        {
            this.AccountMasters = new List<AccountMaster>();
        }

        public long PKID { get; set; }
        public string Name { get; set; }
        public string Balance { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public virtual ICollection<AccountMaster> AccountMasters { get; set; }
    }
}
