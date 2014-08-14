using System.Web.Mvc;
using System.Web.Routing;

namespace MGXAdminConsole
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{myWebForms}.aspx/{*pathInfo}");
            routes.IgnoreRoute("{myWebServices}.asmx/{*pathInfo}");
            routes.IgnoreRoute("myCustomHttpHandler.foo/{*pathInfo}");
            routes.IgnoreRoute("Contents/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );
        }
    }
}
