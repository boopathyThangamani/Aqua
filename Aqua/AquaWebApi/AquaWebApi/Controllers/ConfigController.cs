using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AquaBL;
using AquaVM;
using System.IO;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace AquaWebApi.Controllers
{
    public class ConfigController : ApiController
    {

        [Route("api/Config/{configName}")]
        [HttpGet]
        public List<ConfigVM> Get(string configName)
        {
            var configPath = @"~/App_Data/" + configName + ".json";
            JsonSerializer ser = new JsonSerializer();
            return (List<ConfigVM>)ser.Deserialize(File.OpenText(System.Web.HttpContext.Current.Server.MapPath(configPath)), typeof(List<ConfigVM>));
        }

        [Route("api/Config/GetDropdown")]
        [HttpGet]
        public List<DropdownVM> GetDropdown()
        {
            JsonSerializer ser = new JsonSerializer();
            return (List<DropdownVM>)ser.Deserialize(File.OpenText(System.Web.HttpContext.Current.Server.MapPath(@"~/App_Data/DropDownConfig.json")), typeof(List<DropdownVM>));
        }
    }
}
