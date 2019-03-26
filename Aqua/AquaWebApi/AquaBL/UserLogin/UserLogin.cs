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
    public class UserLogin : IUserLogin
    {

        AquaContext.AquaContext context = new AquaContext.AquaContext();
        public UserLoginVM ValidateUser(string userName, string password)
        {
            IUserModuleEntitlements userModuleEntitlements = new UserModuleEntitlements();
            
            UserLoginVM loginVM = new UserLoginVM();
            UserMasterVM usermaster = Mapper.Map<UserMaster, UserMasterVM > (context.UserMasters.FirstOrDefault(x => x.LoginID.ToLower().Equals(userName.ToLower()) && x.Password.Equals(password)));
            loginVM = Mapper.Map<UserMasterVM, UserLoginVM>(usermaster);
            if(loginVM!=null)
            loginVM.UserModuleEntitlement = userModuleEntitlements.GetEntitlements((int)loginVM.PKID);
            return loginVM;
        }
    }
}
