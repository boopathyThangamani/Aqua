using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace AquaBL
{
    public class ReadConfigs
    {
        public string LoadJson(string key, string filePath)
        {
            //string filePath = System.Web.Hosting.HostingEnvironment.MapPath("~/bin/Config.json").ToString();
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                List<Config> configs = JsonConvert.DeserializeObject<List<Config>>(json);
                return configs.FirstOrDefault(x => x.Key.Equals(key)).Value;
            }
        }
    }
}
