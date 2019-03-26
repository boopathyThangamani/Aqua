using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaVM;
using AutoMapper;

namespace AquaBL
{
    public class AccountGroupMaster : IAccountGroupMaster
    {
        AquaContext.AquaContext context = new AquaContext.AquaContext();

        public AccountGroupMasterVM CreateAccountGroupMaster(AccountGroupMasterVM accGrpMaster)
        {
            accGrpMaster.CreatedDateTime = DateTime.Now;
            try
            {
                context.AccountGroupMasters.Add(Mapper.Map<AccountGroupMasterVM, AquaContext.AccountGroupMaster>(accGrpMaster));
                context.SaveChanges();
                return accGrpMaster;
            }
            catch (Exception ex)
            {
                throw new Exception("Save Account Group Master failed");
            }
        }

        public AccountGroupMasterVM Get(int groupMasterID)
        {

            AccountGroupMasterVM  accountGroupMasterVm = (from accgrp in context.AccountGroupMasters
                join contextAccountTypeMaster in context.AccountTypeMasters on accgrp.AccountTypeFKID equals
                contextAccountTypeMaster.PKID
                where  accgrp.PKID == groupMasterID
                select new AccountGroupMasterVM
                { PKID = accgrp.PKID, AccountTypeMasterName = contextAccountTypeMaster.Name, AccountTypeFKID = accgrp.AccountTypeFKID, Name = accgrp .Name,
                    CreatedBy = accgrp.CreatedBy, CreatedDateTime= accgrp.CreatedDateTime, ModifiedBy= accgrp.ModifiedBy, ModifiedDateTime= accgrp.ModifiedDateTime }).FirstOrDefault() ;



            return accountGroupMasterVm;
        }

        public List<AccountGroupMasterVM> GetAll()
        {
            //return Mapper.Map<List<AquaContext.AccountGroupMaster>, List<AccountGroupMasterVM>>(context.AccountGroupMasters.ToList());
            List<AccountGroupMasterVM> accountGroupMasterVms = (from accgrp in context.AccountGroupMasters
                                                         join contextAccountTypeMaster in context.AccountTypeMasters on accgrp.AccountTypeFKID equals
                                                         contextAccountTypeMaster.PKID
                                                         select new AccountGroupMasterVM
                                                         {
                                                             PKID = accgrp.PKID,
                                                             AccountTypeMasterName = contextAccountTypeMaster.Name,
                                                             AccountTypeFKID = accgrp.AccountTypeFKID,
                                                             Name = accgrp.Name,
                                                             CreatedBy = accgrp.CreatedBy,
                                                             CreatedDateTime = accgrp.CreatedDateTime,
                                                             ModifiedBy = accgrp.ModifiedBy,
                                                             ModifiedDateTime = accgrp.ModifiedDateTime
                                                         }).ToList();
            return accountGroupMasterVms;
        }

        public AccountGroupMasterVM UpdateAccountGroupMaster(AccountGroupMasterVM accGrpMaster)
        {
            accGrpMaster.ModifiedDateTime = DateTime.Now;
            try
            {
                context.Entry(Mapper.Map<AccountGroupMasterVM, AquaContext.AccountGroupMaster>(accGrpMaster)).State = EntityState.Modified;

                context.SaveChanges();
                return accGrpMaster;
            }
            catch (Exception ex)
            {
                throw new Exception("Update Account Group Master Failed");
            }
        }
    }
}
