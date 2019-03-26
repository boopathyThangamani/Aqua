using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaVM;

namespace AquaBL.AccountTypeMaster
{
    public interface IAccountTypeMaster
    {
        List<AccountTypeMasterVM> GetAll();

        AccountTypeMasterVM Get(int accountTypeID);


    }
}
