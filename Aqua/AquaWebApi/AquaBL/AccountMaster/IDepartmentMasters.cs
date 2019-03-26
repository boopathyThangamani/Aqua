using System.Collections.Generic;
using AquaContext;
using AquaVM;

namespace AquaBL
{
    public interface IDepartmentMasters
    {
        List<DepartmentMasterVM> GetAllDepartments();

        DepartmentMasterVM CreateDepartment(DepartmentMasterVM deptMaster);

        DepartmentMasterVM GetDepartment(int deptId);

        DepartmentMasterVM UpdateDepartment(DepartmentMasterVM departmentMaster);
    }
}