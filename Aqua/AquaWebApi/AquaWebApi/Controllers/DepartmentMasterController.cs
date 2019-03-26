using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AquaBL;
using AquaContext;
using AquaVM;
using Swashbuckle.Swagger.Annotations;

namespace AquaWebApi.Controllers
{
    public class DepartmentMasterController : ApiController
    {
        IDepartmentMasters departmentMaster = new DepartmentMasters();
        [HttpGet]
        public List<DepartmentMasterVM> Get()
        {
            return departmentMaster.GetAllDepartments();
        }

        [HttpGet]
        public DepartmentMasterVM Get(int id)
        {
            return departmentMaster.GetDepartment(id);
        }

        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(DepartmentMasterVM))]
        [HttpPost]
        public DepartmentMasterVM Post(DepartmentMasterVM deptMasterVm)
        {
            return departmentMaster.CreateDepartment(deptMasterVm);
        }
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(UserMasterVM))]
        [HttpPut]
        public DepartmentMasterVM Put(DepartmentMasterVM deptMasterVm)
        {
            return departmentMaster.UpdateDepartment(deptMasterVm);
        }

    }

}
