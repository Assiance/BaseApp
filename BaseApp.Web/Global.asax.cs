using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using BaseApp.Web.Areas.HelpPage.Controllers;
using BaseApp.Web.Infrastructure;
using BaseApp.Web.Infrastructure.Tasks;

using StructureMap;

namespace BaseApp.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private const string ContainerKey = "_Container";

        public IContainer Container
        {
            get
            {
                return (IContainer)HttpContext.Current.Items[ContainerKey];
            }
            set
            {
                HttpContext.Current.Items[ContainerKey] = value;
            }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DependencyResolver.SetResolver(new StructureMapDependencyResolver(() => this.Container ?? IoC.Container));

            IoC.Container.Configure(cfg =>
            {
                cfg.AddRegistry(new StandardRegistry());
                cfg.AddRegistry(new ControllerRegistry());
                cfg.AddRegistry(new ActionFilterRegistry(() => this.Container ?? IoC.Container));
                cfg.AddRegistry(new MvcRegistry());
                cfg.AddRegistry(new TaskRegistry());

                //Bug with structure map
                cfg.For<HelpController>().Use(ctx => new HelpController());
            });

            using (var container = IoC.Container.GetNestedContainer())
            {
                foreach (var task in container.GetAllInstances<IRunAtInit>())
                {
                    task.Execute();
                }

                foreach (var task in container.GetAllInstances<IRunAtStartup>())
                {
                    task.Execute();
                }
            }
        }

        public void Application_BeginRequest()
        {
            if (Request.IsSecureConnection)
            {
                Response.AddHeader("Strict-Transport-Security", "max-age=31536000");
            }

            Container = IoC.Container.GetNestedContainer();

            foreach (var task in Container.GetAllInstances<IRunOnEachRequest>())
            {
                task.Execute();
            }
        }

        public void Application_Error()
        {
            foreach (var task in Container.GetAllInstances<IRunOnError>())
            {
                task.Execute();
            }
        }

        public void Application_EndRequest()
        {
            try
            {
                foreach (var task in Container.GetAllInstances<IRunAfterEachRequest>())
                {
                    task.Execute();
                }
            }
            finally
            {
                Container.Dispose();
                Container = null;   
            }
        }
    }
}
