using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using AquaBL;
using AquaVM;
using Swashbuckle.Swagger.Annotations;

namespace AquaWebApi.Controllers
{
    public class AccountGroupMasterController : ApiController
    {
        private readonly IAccountGroupMaster accountGroupMaster = new AccountGroupMaster();

        [HttpGet]
        public List<AccountGroupMasterVM> Get()
        {
            return accountGroupMaster.GetAll();
        }

        [HttpGet]
        public AccountGroupMasterVM Get(int id)
        {
            return accountGroupMaster.Get(id);
        }


        [HttpPost]

        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(AccountGroupMasterVM))]
        public AccountGroupMasterVM Post(AccountGroupMasterVM accMasterVm)
        {
            return accountGroupMaster.CreateAccountGroupMaster(accMasterVm);
        }
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(AccountGroupMasterVM))]
        [HttpPut]
        public AccountGroupMasterVM Put(AccountGroupMasterVM accMasterVm)
        {
            return accountGroupMaster.UpdateAccountGroupMaster(accMasterVm);
        }
    }
}