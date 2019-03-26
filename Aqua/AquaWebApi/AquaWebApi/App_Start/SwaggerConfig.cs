using System.Web.Http;
using WebActivatorEx;
using AquaWebApi;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace AquaWebApi
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration 
                .EnableSwagger(c =>
                    {
                        
                        c.SingleApiVersion("v1", "AquaWebApi");
                        c.IncludeXmlComments(GetXmlCommentsPath());
                    })
                .EnableSwaggerUi(c =>
                    {
                        
                    });

            
        }

        protected static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}bin\AquaWebApi.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
