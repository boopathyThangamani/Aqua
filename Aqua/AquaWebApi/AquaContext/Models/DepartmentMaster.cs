using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class DepartmentMaster
    {
        public DepartmentMaster()
        {
            this.UserMasters = new List<UserMaster>();
        }

        public long PKID { get; set; }
        public string Name { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public virtual ICollection<UserMaster> UserMasters { get; set; }
    }
}
