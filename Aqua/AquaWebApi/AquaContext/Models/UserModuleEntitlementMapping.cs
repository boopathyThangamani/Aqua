using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class UserModuleEntitlementMapping
    {
        public long PKID { get; set; }
        public long UserFKID { get; set; }
        public long ModuleFKID { get; set; }
        public bool IsReport { get; set; }
        public bool HasView { get; set; }
        public bool HasCRUD { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public virtual ModuleReference ModuleReference { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
