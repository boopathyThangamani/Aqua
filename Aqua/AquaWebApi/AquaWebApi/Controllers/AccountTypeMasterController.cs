using System.Collections.Generic;
using System.Web.Http;
using AquaBL.AccountTypeMaster;
using AquaVM;

namespace AquaWebApi.Controllers
{
    public class AccountTypeMasterController : ApiController
    {
        private readonly IAccountTypeMaster accountTypeMaster = new AccountTypeMaster();

        [HttpGet]
        public List<AccountTypeMasterVM> Get()
        {
            return accountTypeMaster.GetAll();
        }

        [HttpGet]
        public AccountTypeMasterVM Get(int id)
        {
            return accountTypeMaster.Get(id);
        }

        //public AccountMasterVM Post(AccountMasterVM accMasterVm)
        //[HttpPost]

        //[SwaggerResponse(HttpStatusCode.OK, Type = typeof(AccountMasterVM))]
        //{
        //    return accountTypeMaster.CreateAccountMaster(accMasterVm);
        //}
        //[SwaggerResponse(HttpStatusCode.OK, Type = typeof(AccountMasterVM))]
        //[HttpPut]
        //public AccountMasterVM Put(AccountMasterVM accMasterVm)
        //{
        //    return accountTypeMaster.UpdateAccountMaster(accMasterVm);
        //}
    }
}