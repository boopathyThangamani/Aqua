using System.Collections.Generic;
using AquaContext;
using AquaVM;

namespace AquaBL
{
    public interface IAccountMasters
    {
        List<AccountMasterVM> GetAllAccountMasters();

        AccountMasterVM CreateAccountMaster(AccountMasterVM deptMaster);

        AccountMasterVM GetAccountMaster(int deptId);

        AccountMasterVM UpdateAccountMaster(AccountMasterVM departmentMaster);
    }
}