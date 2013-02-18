﻿using System.Web;
using System.Web.Http;
using ApiComparison.WebApi.Controllers;
using ApiComparison.WebApi.Controllers.Objects;
using MvcCodeRouting;

namespace ApiComparison.WebApi
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configuration.Routes.MapCodeRoutes(
                rootController: typeof (ObjectsController),
                settings: new CodeRoutingSettings
                    {
                        UseImplicitIdToken = true
                    }
                );
        }
    }
}