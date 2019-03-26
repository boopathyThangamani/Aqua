using System.Collections.Generic;
using AquaContext;
using AquaVM;

namespace AquaBL
{
    public interface IUserMasters
    {
        UserMasterVM CreateUser(UserMasterVM userMaster);

        List<UserMasterVM> GetAllUsers();

        UserMasterVM GetUserMaster(int userId);

        UserMasterVM UpdateUser(UserMasterVM userMaster);

        bool ValidateLoginID(int userID, string loginIDToValidate);
    }
}