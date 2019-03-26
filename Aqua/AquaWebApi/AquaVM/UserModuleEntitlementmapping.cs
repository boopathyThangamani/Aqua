using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVM
{
    public class UserModuleEntitlementMappingVM
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
        public string UserName { get; set; }
        public string ModuleName { get; set; }
    }
}
