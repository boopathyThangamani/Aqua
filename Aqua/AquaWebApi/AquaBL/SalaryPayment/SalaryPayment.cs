using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AquaContext;
using AquaVM;
using AutoMapper;

namespace AquaBL
{
    public class SalaryPayment : ISalaryPayment
    {
        AquaContext.AquaContext context =new AquaContext.AquaContext();
        Journals journalBL = new Journals();

        public int CreateSalaryPayment(List<SalaryPaymentVM> salaryPaymentVM, string filePath)
        {
            return CreateUpdate(salaryPaymentVM, filePath);
        }
        public List<SalaryPaymentVM> GetAllPendingSalary(int deptID)
        {
            SqlParameter deptIdParam = new SqlParameter("@DepartmentID", deptID);
            var pendingSalary = context.Database.SqlQuery<SalaryPaymentVM>("GetUserPendingSalary @DepartmentID", deptIdParam).ToList();
            return pendingSalary;
        }

        private int CreateUpdate(List<SalaryPaymentVM> salaryPayment, string filePath)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                foreach (SalaryPaymentVM spvm in salaryPayment)
                {
                    spvm.CreatedDateTime = DateTime.Now;
                    Journal journal = MapJournalForCreate(spvm, filePath);
                    if (spvm.PKID == 0 && spvm.JournalFKID == 0)
                    {
                        Journal savedJournal = journalBL.CreateJournal(journal);
                        spvm.JournalFKID = savedJournal.PKID;
                        spvm.Date = spvm.TransactionDate;
                        context.SalaryPayments.Add(Mapper.Map<SalaryPaymentVM, AquaContext.SalaryPayment>(spvm));
                        context.SaveChanges();
                    }
                    else
                    {
                        Journal savedJournal = journalBL.UpdateJournal(journal);
                        spvm.JournalFKID = savedJournal.PKID;
                        spvm.Date = spvm.TransactionDate;
                        var salaryPaymentToDelete = context.SalaryPayments.Where(x => x.PKID == spvm.PKID).First();

                        context.SalaryPayments.Remove(salaryPaymentToDelete);
                        context.SalaryPayments.Add(Mapper.Map<SalaryPaymentVM, AquaContext.SalaryPayment>(spvm));
                        context.SaveChanges();

                    }

                }
                scope.Complete();
            }
            return 1;
        }

        private Journal MapJournalForCreate(SalaryPaymentVM salaryPayment, string filePath)
        {
            ReadConfigs readConfigs = new ReadConfigs();
            string moduleCode = readConfigs.LoadJson("SalaryPayment", filePath + "\\ModuleConfig.json");
            Journal journal = new Journal();
            journal.DebitACFKID = salaryPayment.UserAccountFKID.Value;
            journal.Amount = salaryPayment.Amount;
            journal.CreatedBy = salaryPayment.CreatedBy;
            journal.CreatedDateTime = salaryPayment.CreatedDateTime;
            journal.Date = salaryPayment.TransactionDate.Value;
            journal.CreditACFKID = (Convert.ToBoolean(Convert.ToInt32(salaryPayment.isCash))) ? Convert.ToInt64(readConfigs.LoadJson("Cash", filePath + "\\AccountConfig.json")) : Convert.ToInt64(readConfigs.LoadJson("Bank", filePath + "\\AccountConfig.json"));
            journal.ModuleCode = moduleCode;
            journal.ReferenceID = 1;
            journal.PKID = salaryPayment.JournalFKID;
            return journal;
        }
    }
}
