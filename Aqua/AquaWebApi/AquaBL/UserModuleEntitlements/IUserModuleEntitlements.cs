using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaVM;

namespace AquaBL
{
    public interface IUserModuleEntitlements
    {
        List<UserModuleEntitlementMappingVM> GetEntitlements(int userid);

        List<UserModuleEntitlementMappingVM> GetEntitlements();

        int CreateEntitlements(List<UserModuleEntitlementMappingVM> entitlments);
    }
}
