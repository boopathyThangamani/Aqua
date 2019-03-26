using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using AquaBL;
using AquaVM;
using Swashbuckle.Swagger.Annotations;

namespace AquaWebApi.Controllers
{
    public class SalaryDeclerationController : ApiController
    {
        private readonly ISalaryDecleration salaryDecleration = new SalaryDecleration();

        [Route("api/SalaryDecleration/{deptID}/{mon}/{yr}")]
        [HttpGet]
        public List<SalaryDeclarationVM> Get(int deptID, string mon, int yr)
        {
            return salaryDecleration.GetAllSalaryDecleration(deptID,mon,yr);
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(SalaryDeclarationVM))]
        public int Post(List<SalaryDeclarationVM> salaryDeclerationVM)
        {
            string filePath = System.Web.HttpContext.Current.Server.MapPath(@"~/App_Data/");
            return salaryDecleration.CreateSalaryDecleration(salaryDeclerationVM,filePath);
        }
    }
}