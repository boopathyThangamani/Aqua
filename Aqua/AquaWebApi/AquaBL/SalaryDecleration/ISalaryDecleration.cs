using System.Collections.Generic;
using AquaContext;
using AquaVM;

namespace AquaBL
{
    public interface ISalaryDecleration
    {
        int CreateSalaryDecleration(List<SalaryDeclarationVM> salaryDeclerationVM, string filePath);

        List<SalaryDeclarationVM> GetAllSalaryDecleration(int deptID, string month, int year);

    }
}