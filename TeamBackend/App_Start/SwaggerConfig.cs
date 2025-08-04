using System.Web.Http;
using WebActivatorEx;
using Swashbuckle.Application;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TeamBackend.App_Start.SwaggerConfig), "Register")]

namespace TeamBackend.App_Start
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "TeamBackend API");
                })
                .EnableSwaggerUi();
        }
    }
}
