using System.Linq;
using System.Web.Mvc;

namespace BaseApp.Web.Infrastructure
{
    public class EverfluxViewEngine : RazorViewEngine
    {
        private static string[] additionalViewLocations =
            {
                "~/ViewsAngular/{1}/{0}.cshtml",
                "~/ViewsAngular/{1}/{0}.vbhtml",
                "~/ViewsAngular/Shared/{0}.cshtml",
                "~/ViewsAngular/Shared/{0}.vbhtml"
            };

        public EverfluxViewEngine()
        {
            PartialViewLocationFormats = PartialViewLocationFormats.Union(additionalViewLocations).ToArray();
            ViewLocationFormats = ViewLocationFormats.Union(additionalViewLocations).ToArray();
            MasterLocationFormats = MasterLocationFormats.Union(additionalViewLocations).ToArray();
        }
    }
}