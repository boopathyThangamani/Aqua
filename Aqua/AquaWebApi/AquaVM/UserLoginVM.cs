using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVM
{
    public class UserLoginVM
    {
        public long PKID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<System.DateTime> DOR { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> Admin { get; set; }
        public string Designation { get; set; }
        public Nullable<long> DepartmentFKID { get; set; }
        public string LoginID { get; set; }
        public Nullable<bool> HasLogin { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public string Password { get; set; }
        public Nullable<long> AccountFKID { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public string OpeningBalanceType { get; set; }
        public Nullable<System.DateTime> OpeningBalanceDate { get; set; }

        public string DepartmentName { get; set; }

        public List<UserModuleEntitlementMappingVM> UserModuleEntitlement { get; set; }
    }
}
