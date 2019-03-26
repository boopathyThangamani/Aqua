using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class UserMaster
    {
        public UserMaster()
        {
            this.SalaryDeclarations = new List<SalaryDeclaration>();
            this.SalaryPayments = new List<SalaryPayment>();
            this.UserModuleEntitlementMappings = new List<UserModuleEntitlementMapping>();
        }

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
        public virtual DepartmentMaster DepartmentMaster { get; set; }
        public virtual ICollection<SalaryDeclaration> SalaryDeclarations { get; set; }
        public virtual ICollection<SalaryPayment> SalaryPayments { get; set; }
        public virtual ICollection<UserModuleEntitlementMapping> UserModuleEntitlementMappings { get; set; }
    }
}
