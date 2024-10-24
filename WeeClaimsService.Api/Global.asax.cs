using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;
using Unity;
using Unity.WebApi;
using WeeClaimsService.Api.App_Start;
using WeeClaimsService.Api.Helpers.Mappers;
using WeeClaimsService.Api.Repositories;

namespace WeeClaimsService.Api
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            SwaggerConfig.Register();

            //Configuraion del mapper
            var unityContainer = new UnityContainer();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            unityContainer.RegisterInstance<IMapper>(mapper);
            unityContainer.RegisterType<ICompaniRepositori, CompaniRepositori>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(unityContainer);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Url.AbsolutePath == "/")
            {
                HttpContext.Current.Response.Redirect("~/swagger/ui/index#/Compania");
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}