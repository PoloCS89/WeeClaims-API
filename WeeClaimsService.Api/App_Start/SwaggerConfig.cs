using System.Web.Http;
using WebActivatorEx;
using WeeClaimsService.Api;
using Swashbuckle.Application;

namespace WeeClaimsService.Api
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "WeeClaimsApi");
                })
                .EnableSwaggerUi();
        }
    }
}
