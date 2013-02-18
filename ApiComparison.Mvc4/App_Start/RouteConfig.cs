using System.Web.Mvc;
using System.Web.Routing;

namespace ApiComparison.Mvc4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CreateObjectAndRedirect",
                url: "objects/",
                defaults: new { controller = "Example", action = "CreateObjectAndRedirect" }
            );

            // NOTE! THIS ONE MUST BE REGISTERED BEFORE THE PARAMETERISED ROUTE BELOW!
            routes.MapRoute(
                name: "GetNonExistingObject",
                url: "objects/missing",
                defaults: new {controller = "Example", action = "GetNonExistingObject"}
                );

            routes.MapRoute(
                name: "GetStreamWithContentType",
                url: "objects/stream",
                defaults: new { controller = "Example", action = "GetStreamWithContentType" }
            );

            routes.MapRoute(
                name: "GetObject",
                url: "objects/{id}",
                defaults: new { controller = "Example", action = "GetObject" }
            );
        }
    }
}