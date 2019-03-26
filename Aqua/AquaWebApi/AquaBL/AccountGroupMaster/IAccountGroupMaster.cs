using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaVM;

namespace AquaBL
{
    public interface IAccountGroupMaster
    {
        List<AccountGroupMasterVM> GetAll();

        AccountGroupMasterVM Get(int groupMasterID);

        AccountGroupMasterVM UpdateAccountGroupMaster(AccountGroupMasterVM accGrpMaster);

        AccountGroupMasterVM CreateAccountGroupMaster(AccountGroupMasterVM accGrpMaster);
    }
}
