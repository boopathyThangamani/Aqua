using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaVM;
using AutoMapper;
using AquaContext;

namespace AquaBL
{
    public class UserModuleEntitlements : IUserModuleEntitlements
    {

        AquaContext.AquaContext context = new AquaContext.AquaContext();

        public int CreateEntitlements(List<UserModuleEntitlementMappingVM> entitlments)
        {
            foreach(var ent in entitlments)
            {
                if (ent.PKID == 0)
                {
                    ent.CreatedDateTime = DateTime.Now;
                    context.UserModuleEntitlementMappings.Add(Mapper.Map<UserModuleEntitlementMappingVM, UserModuleEntitlementMapping>(ent));
                }
                else
                {
                    ent.ModifiedDateTime = DateTime.Now;
                    context.Entry(Mapper.Map<UserModuleEntitlementMappingVM, UserModuleEntitlementMapping>(ent)).State = System.Data.Entity.EntityState.Modified;
                }
            }
            return context.SaveChanges();
        }

        public List<UserModuleEntitlementMappingVM> GetEntitlements()
        {
            return Mapper.Map<List<UserModuleEntitlementMapping>, List<UserModuleEntitlementMappingVM>>(context.UserModuleEntitlementMappings.ToList());
        }

        public List<UserModuleEntitlementMappingVM> GetEntitlements(int userid)
        {
            List<UserModuleEntitlementMapping> result = null;
            result = context.UserModuleEntitlementMappings.Where(x => x.UserFKID == userid).ToList();
            List<ModuleReference> moduleReferences = context.ModuleReferences.ToList();
            //if user is very new and no entitlements found
            if (!result.Any())
            {
                result = new List<UserModuleEntitlementMapping>();
                foreach (var moduleReference in moduleReferences)
                {
                    result.Add(new UserModuleEntitlementMapping()
                    {
                        ModuleFKID = moduleReference.PKID,
                        ModuleReference = moduleReference,
                        UserFKID = userid,
                    });
                }
            }
            //if user has entitlements but new module is added in modules table
            else
            {
                var moduleids = new HashSet<long>(result.Select(x => x.ModuleFKID));
                List<ModuleReference> moduleReferencesNotExists = moduleReferences.Where(x => !moduleids.Contains(x.PKID)).ToList();
                UserMaster userMaster = context.UserMasters.FirstOrDefault(x => x.PKID == userid);
                foreach (var moduleReference in moduleReferencesNotExists)
                {
                    result.Add(new UserModuleEntitlementMapping()
                    {
                        ModuleFKID = moduleReference.PKID,
                        ModuleReference = moduleReference,
                        UserFKID = userid,
                        UserMaster = userMaster
                    });
                }
            }

            return Mapper.Map < List<UserModuleEntitlementMapping>, List < UserModuleEntitlementMappingVM >>(result);
        }

    }
}
