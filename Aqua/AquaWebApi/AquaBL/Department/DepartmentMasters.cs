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
    public class DepartmentMasters : IDepartmentMasters
    {
        AquaContext.AquaContext context = new AquaContext.AquaContext();

        public DepartmentMasterVM CreateDepartment(DepartmentMasterVM deptMaster)
        {
            deptMaster.CreatedDateTime = DateTime.Now;
            try
            {
                context.DepartmentMasters.Add(Mapper.Map<DepartmentMasterVM, DepartmentMaster>(deptMaster));
                context.SaveChanges();
                return deptMaster;
            }
            catch (Exception ex)
            {
                throw new Exception("Save Department failed");
            }

        }

        public List<DepartmentMasterVM> GetAllDepartments()
        {
            return Mapper.Map<List<DepartmentMaster>, List<DepartmentMasterVM>>(context.DepartmentMasters.ToList());
        }

        public DepartmentMasterVM GetDepartment(int deptId)
        {
            return
                Mapper.Map<DepartmentMaster, DepartmentMasterVM>(
                    context.DepartmentMasters.FirstOrDefault(x => x.PKID == deptId));
        }

        public DepartmentMasterVM UpdateDepartment(DepartmentMasterVM departmentMaster)
        {
            departmentMaster.ModifiedDateTime = DateTime.Now;
            try
            {
                context.Entry(Mapper.Map<DepartmentMasterVM, DepartmentMaster>(departmentMaster)).State = EntityState.Modified;

                context.SaveChanges();
                return departmentMaster;
            }
            catch (Exception ex)
            {
                throw new Exception("Update department Failed");
            }
        }
    }
}
