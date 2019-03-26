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
    public class UserLoginController : ApiController
    {
        IUserLogin userLogin = new UserLogin();
        [Route(("api/UserLogin/{userName}/{password}"))]
        [HttpGet]
        public UserLoginVM Get(string userName, string password)
        {
            return userLogin.ValidateUser(userName, password);
        }
    }
}
