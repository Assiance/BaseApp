using System.IO;
using System.Web;
using System.Web.Optimization;

namespace BaseApp.Web
{
    public class BundleConfig
    {
        private const string _AppDirectory = "app";

        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/bundles/angularjs").Include(
                     "~/Scripts/angularjs/angular.js",
                     "~/Scripts/angularjs/angular-sanitize.js",
                     "~/Scripts/angularjs/angular-cookies.js",
                     "~/Scripts/angularjs/angular-resource.js",
                     "~/Scripts/angularjs-ui/angular-ui-router.js"));

            AddAppBundles(bundles);

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }

        private static void AddAppBundles(BundleCollection bundles)
        {
            var scriptBundle = new ScriptBundle("~/bundles/appScripts");
            var adminAppDirFullPath = HttpContext.Current.Server.MapPath(string.Format("~/{0}", _AppDirectory));
            if (Directory.Exists(adminAppDirFullPath))
            {
                scriptBundle.Include(

                    // Order matters, so get the core app setup first
                    string.Format("~/{0}/app.module.js", _AppDirectory),
                    string.Format("~/{0}/app.core.module.js", _AppDirectory))

                    // then get any other top level js files
                    .IncludeDirectory(string.Format("~/{0}", _AppDirectory), "*.js", false)

                    // then get all nested module js files
                    .IncludeDirectory(string.Format("~/{0}", _AppDirectory), "*.module.js", true)

                    // finally, get all the other js files
                    .IncludeDirectory(string.Format("~/{0}", _AppDirectory), "*.js", true);
            }
            bundles.Add(scriptBundle);
        }
    }
}
