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
    public class SalaryDecleration : ISalaryDecleration
    {
        AquaContext.AquaContext context = new AquaContext.AquaContext();
        Journals journalBL = new Journals();

        public int CreateSalaryDecleration(List<SalaryDeclarationVM> salaryDeclerationVM , string filePath)
        {
            return CreateUpdate(salaryDeclerationVM, filePath);
        }

        public List<SalaryDeclarationVM> GetAllSalaryDecleration()
        {
            return Mapper.Map<List<SalaryDeclaration>, List<SalaryDeclarationVM>>(context.SalaryDeclarations.ToList());
        }

        public List<SalaryDeclarationVM> GetAllSalaryDecleration(int deptID, string mon, int yr)
        {
            return (from u in context.UserMasters
                    join sd in context.SalaryDeclarations on new { userid = u.PKID, month = mon, year = yr }
                    equals new { userid = sd.UserFKID, month = sd.Month, year = sd.Year } into temp
                    join d in context.DepartmentMasters on u.DepartmentFKID equals d.PKID
                    where d.PKID == deptID
                    from t in temp.DefaultIfEmpty()
                    select new SalaryDeclarationVM
                    {
                        PKID = (t == null) ? 0 : t.PKID,
                        Amount = (t == null) ? 0 : t.Amount,
                        JournalFKID = (t == null) ? 0 : t.JournalFKID,
                        TransactionDate = (t == null) ? null : t.TransactionDate,
                        UserFKID = (t == null) ? u.PKID : (t.UserFKID == 0) ? u.PKID : t.UserFKID,
                        Month = (t == null) ? mon : (t.Month == null) ? mon : t.Month,
                        UserName = u.Name,
                        Year = (t == null) ? yr : (t.Year == 0) ? yr : t.Year,
                        UserAccountFKID = u.AccountFKID
                    }).ToList();
        }

        private int CreateUpdate(List<SalaryDeclarationVM> salaryDecleration, string filePath)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                foreach (SalaryDeclarationVM sdvm in salaryDecleration)
                {
                    sdvm.CreatedDateTime = DateTime.Now;
                    Journal journal = MapJournalForCreate(sdvm, filePath);
                    if (sdvm.PKID == 0 && sdvm.JournalFKID == 0)
                    {
                        Journal savedJournal = journalBL.CreateJournal(journal);
                        sdvm.JournalFKID = savedJournal.PKID;
                        context.SalaryDeclarations.Add(Mapper.Map<SalaryDeclarationVM, SalaryDeclaration>(sdvm));
                        context.SaveChanges();
                    }
                    else
                    {
                        Journal savedJournal = journalBL.UpdateJournal(journal);
                        sdvm.JournalFKID = savedJournal.PKID;

                        var salaryDeclerationToDelete = context.SalaryDeclarations.Where(x => x.PKID == sdvm.PKID).First();

                        context.SalaryDeclarations.Remove(salaryDeclerationToDelete);
                        context.SalaryDeclarations.Add(Mapper.Map<SalaryDeclarationVM, SalaryDeclaration>(sdvm));
                        context.SaveChanges();

                    }

                }
                scope.Complete();
            }
            return 1;
        }

        private Journal MapJournalForCreate(SalaryDeclarationVM salaryDecleration, string filePath)
        {
            ReadConfigs readConfigs = new ReadConfigs();
            long debitAckFKID = Convert.ToInt64(readConfigs.LoadJson("Salary", filePath + "\\AccountConfig.json"));
            string moduleCode = readConfigs.LoadJson("SalaryDeclaration", filePath + "\\ModuleConfig.json");
            Journal journal = new Journal();
            journal.CreditACFKID = salaryDecleration.UserAccountFKID.Value;
            journal.Amount = salaryDecleration.Amount;
            journal.CreatedBy = salaryDecleration.CreatedBy;
            journal.CreatedDateTime = salaryDecleration.CreatedDateTime;
            journal.Date = salaryDecleration.TransactionDate.Value;
            journal.DebitACFKID = debitAckFKID;
            journal.ModuleCode = moduleCode;
            journal.ReferenceID = 1;
            journal.PKID = salaryDecleration.JournalFKID;
            return journal;
        }
    }
}
