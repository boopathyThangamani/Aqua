using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AquaBL;
using AquaVM;
using Swashbuckle.Swagger.Annotations;

namespace AquaWebApi.Controllers
{
    public class SalaryPaymentController : ApiController
    {
        private readonly ISalaryPayment salaryPayment = new SalaryPayment();

        [Route("api/SalaryPayment/{deptID}")]
        [HttpGet]
        public List<SalaryPaymentVM> Get(int deptID)
        {
            return salaryPayment.GetAllPendingSalary(deptID);
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(SalaryPaymentVM))]
        public int Post(List<SalaryPaymentVM> salaryPaymentVM)
        {
            string filePath = System.Web.HttpContext.Current.Server.MapPath(@"~/App_Data/");
            return salaryPayment.CreateSalaryPayment(salaryPaymentVM, filePath);
        }
    }
}
