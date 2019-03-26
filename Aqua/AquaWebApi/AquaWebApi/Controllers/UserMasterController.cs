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
    public class UserMasterController : ApiController
    {
        IUserMasters userMaster = new UserMasters();
        public List<UserMasterVM> Get()
        {
            return userMaster.GetAllUsers();
        }
        public UserMasterVM Get(int id)
        {
            return userMaster.GetUserMaster(id);
        }

        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(string))]
        [Route("api/UserMaster/{userID}/{loginIDToValidate}")]
        [HttpGet]
        public bool ValidateUserLoginID(int userID, string loginIDToValidate)
        {
            return userMaster.ValidateLoginID(userID,loginIDToValidate);
        }
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(UserMasterVM))]
        [HttpPost]
        public UserMasterVM Post(UserMasterVM userMasterVm)
        {
            return userMaster.CreateUser(userMasterVm);
        }
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(UserMasterVM))]
        [HttpPut]
        public UserMasterVM Put(UserMasterVM userMasterVm)
        {
            return userMaster.UpdateUser(userMasterVm);
        }
    }
}
