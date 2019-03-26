using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaContext;
using AquaVM;
using AutoMapper;

namespace AquaBL.AccountTypeMaster
{
    public class AccountTypeMaster : IAccountTypeMaster
    {
        AquaContext.AquaContext context = new AquaContext.AquaContext();

        public AccountTypeMasterVM Get(int accountTypeID)
        {
            return Mapper.Map<AquaContext.AccountTypeMaster, AccountTypeMasterVM>(context.AccountTypeMasters.FirstOrDefault(x => x.PKID == accountTypeID));
        }

        public List<AccountTypeMasterVM> GetAll()
        {
            return Mapper.Map<List<AquaContext.AccountTypeMaster>, List<AccountTypeMasterVM>>(context.AccountTypeMasters.ToList());
        }
    }
}
