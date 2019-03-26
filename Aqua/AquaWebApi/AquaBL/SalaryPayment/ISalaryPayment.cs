using System.Collections.Generic;
using AquaContext;
using AquaVM;

namespace AquaBL
{
    public interface ISalaryPayment
    {
        List<SalaryPaymentVM> GetAllPendingSalary(int deptID);

        int CreateSalaryPayment(List<SalaryPaymentVM> salaryPaymentVM, string filePath);
    }
}