using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaContext;
using AquaVM;
using AutoMapper;

namespace AquaBL
{
    public class AccountMasters : IAccountMasters
    {
        AquaContext.AquaContext context = new AquaContext.AquaContext();

        public AccountMasterVM CreateAccountMaster(AccountMasterVM accMaster)
        {
            accMaster.CreatedDateTime = DateTime.Now;
            try
            {
                context.AccountMasters.Add(Mapper.Map<AccountMasterVM, AccountMaster>(accMaster));
                context.SaveChanges();
                return accMaster;
            }
            catch (Exception ex)
            {
                throw new Exception("Save Account Master failed");
            }

        }

        public List<AccountMasterVM> GetAllAccountMasters()
        {
            return Mapper.Map<List<AccountMaster>, List<AccountMasterVM>>(context.AccountMasters.ToList());
        }

        public AccountMasterVM GetAccountMaster(int accId)
        {
            return
                Mapper.Map<AccountMaster, AccountMasterVM>(
                    context.AccountMasters.FirstOrDefault(x => x.PKID == accId));
        }

        public AccountMasterVM UpdateAccountMaster(AccountMasterVM accMaster)
        {
            accMaster.ModifiedDateTime = DateTime.Now;
            try
            {
                context.Entry(Mapper.Map<AccountMasterVM, AccountMaster>(accMaster)).State = EntityState.Modified;

                context.SaveChanges();
                return accMaster;
            }
            catch (Exception ex)
            {
                throw new Exception("Update Account Master Failed");
            }
        }
    }
}
