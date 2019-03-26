using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AquaBL;
using AquaContext;
using AquaVM;
using Swashbuckle.Swagger.Annotations;

namespace AquaWebApi.Controllers
{
    public class AccountMasterController : ApiController
    {
        IAccountMasters accountMaster = new AccountMasters();
        [HttpGet]
        public List<AccountMasterVM> Get()
        {
            return accountMaster.GetAllAccountMasters();
        }

        [HttpGet]
        public AccountMasterVM Get(int id)
        {
            return accountMaster.GetAccountMaster(id);
        }

        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(AccountMasterVM))]
        [HttpPost]
        public AccountMasterVM Post(AccountMasterVM accMasterVm)
        {
            return accountMaster.CreateAccountMaster(accMasterVm);
        }
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(AccountMasterVM))]
        [HttpPut]
        public AccountMasterVM Put(AccountMasterVM accMasterVm)
        {
            return accountMaster.UpdateAccountMaster(accMasterVm);
        }

    }

}
