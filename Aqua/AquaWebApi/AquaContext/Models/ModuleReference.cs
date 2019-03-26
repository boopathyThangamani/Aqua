using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class ModuleReference
    {
        public ModuleReference()
        {
            this.UserModuleEntitlementMappings = new List<UserModuleEntitlementMapping>();
        }

        public long PKID { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleDescription { get; set; }
        public string RelatedTable { get; set; }
        public virtual ICollection<UserModuleEntitlementMapping> UserModuleEntitlementMappings { get; set; }
    }
}
