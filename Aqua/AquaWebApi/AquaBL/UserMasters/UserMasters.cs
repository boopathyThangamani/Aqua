using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AquaContext;
using AquaVM;
using AutoMapper;

namespace AquaBL
{
    public class UserMasters : IUserMasters
    {
        AquaContext.AquaContext context = new AquaContext.AquaContext();

        public UserMasterVM CreateUser(UserMasterVM userMaster)
        {
            userMaster.CreatedDateTime = DateTime.Now;
            AccountMaster accountMaster = MapAccountMasterForCreate(userMaster);
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    context.AccountMasters.Add(accountMaster);
                    context.SaveChanges();

                    userMaster.AccountFKID = accountMaster.PKID;
                    context.UserMasters.Add(Mapper.Map<UserMasterVM, UserMaster>(userMaster));
                    context.SaveChanges();
                    scope.Complete();
                    return userMaster;
                }
                catch (Exception ex)
                {
                    throw new Exception("Save user Failed");
                }
            }

        }

        public UserMasterVM UpdateUser(UserMasterVM userMaster)
        {
                userMaster.ModifiedDateTime = DateTime.Now;
                AccountMaster accountMaster = MapAccountMasterForUpdate(userMaster);

                try
                {
                    context.Entry(accountMaster).State = EntityState.Modified;

                    context.Entry(Mapper.Map<UserMasterVM, UserMaster>(userMaster)).State = EntityState.Modified;

                    context.SaveChanges();
                    return userMaster;
                }
                catch (Exception ex)
                {
                    throw new Exception("Update user Failed");
                }

        }

        public List<UserMasterVM> GetAllUsers()
        {
            return Mapper.Map<List<UserMaster>, List<UserMasterVM>>(context.UserMasters.ToList());
        }

        public UserMasterVM GetUserMaster(int userId)
        {
            return Mapper.Map<UserMaster, UserMasterVM>(context.UserMasters.FirstOrDefault(x => x.PKID == userId));
        }

        public bool ValidateLoginID(int userID, string loginIDToValidate)
        {
            if(userID == 0) return (context.UserMasters.Where(x => x.LoginID.ToLower().Equals(loginIDToValidate.ToLower())).ToList().Any());
            else
            {
                return (context.UserMasters.Where(x => x.LoginID.ToLower().Equals(loginIDToValidate.ToLower()) && x.PKID != userID ).ToList().Any());
            }
        }

        private AccountMaster MapAccountMasterForCreate(UserMasterVM userMaster)
        {
            AccountMaster accountMaster = new AccountMaster();
            accountMaster.Name = userMaster.Name;
            accountMaster.OpeningBalanceType = userMaster.OpeningBalanceType;
            accountMaster.Date = userMaster.OpeningBalanceDate;
            if (userMaster.OpeningBalance != null) accountMaster.OpeningBalance = userMaster.OpeningBalance.Value;
            accountMaster.CreatedBy = userMaster.CreatedBy.GetValueOrDefault();
            accountMaster.CreatedDateTime = userMaster.CreatedDateTime.GetValueOrDefault();


            var agm =
                context.AccountGroupMasters.FirstOrDefault(
                    x => context.AccountTypeMasters.Where(atm => atm.Name.ToLower().Equals("expenses"))
                        .Select(a => a.PKID)
                        .Contains(x.AccountTypeFKID));
            if (agm != null)
            {
                accountMaster.AccountTypeFKID = agm.AccountTypeFKID;
                accountMaster.AccountGroupFKID = agm.PKID;
            }
            else
            {
                var atm = context.AccountTypeMasters.Where(x => x.Name.ToLower().Equals("expenses"))
                    .Select(a => a.PKID).FirstOrDefault();
                accountMaster.AccountTypeFKID = atm;
            }
            return accountMaster;
        }

        private AccountMaster MapAccountMasterForUpdate(UserMasterVM userMaster)
        {
            AccountMaster accountMaster =
                context.AccountMasters.FirstOrDefault(x => x.PKID == userMaster.AccountFKID.Value);
            if (accountMaster != null)
            {
                accountMaster.Name = userMaster.Name;
                accountMaster.OpeningBalanceType = userMaster.OpeningBalanceType;
                accountMaster.Date = userMaster.OpeningBalanceDate;
                if (userMaster.OpeningBalance != null) accountMaster.OpeningBalance = userMaster.OpeningBalance.Value;
                accountMaster.ModifiedBy = userMaster.ModifiedBy.GetValueOrDefault();
                accountMaster.ModifiedDateTime = userMaster.ModifiedDateTime.GetValueOrDefault();
                return accountMaster;
            }
            return new AccountMaster();
        }
    }
}
