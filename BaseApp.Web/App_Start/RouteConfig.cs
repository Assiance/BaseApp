using System.Web.Mvc;
using System.Web.Routing;
using BaseApp.Web.Infrastructure;

namespace BaseApp.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Disabled when not using MVC
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } //Changed default route to layout controller
            //);
        }
    }
}
