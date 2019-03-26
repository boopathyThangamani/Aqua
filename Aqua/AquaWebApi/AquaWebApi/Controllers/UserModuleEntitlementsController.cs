using AquaVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AquaBL;

namespace AquaWebApi.Controllers
{
    public class UserModuleEntitlementsController : ApiController
    {
        IUserModuleEntitlements userModuleEntitlements = new UserModuleEntitlements();

        [Route(("api/UserModuleEntitlement/{Id}"))]
        [HttpGet]
        public List<UserModuleEntitlementMappingVM> Get(int Id)
        {
            return userModuleEntitlements.GetEntitlements(Id);
        }

        [Route("api/UserModuleEntitlement/")]
        [HttpGet]
        public List<UserModuleEntitlementMappingVM> Get()
        {
            return userModuleEntitlements.GetEntitlements();
        }

        [Route("api/UserModuleEntitlement/")]
        [HttpPost]
        public int Post(List<UserModuleEntitlementMappingVM> userEntitlements )
        {
            return userModuleEntitlements.CreateEntitlements(userEntitlements);
        }

    }
}
