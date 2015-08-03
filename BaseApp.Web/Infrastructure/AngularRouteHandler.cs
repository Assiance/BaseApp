using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BaseApp.Web.Infrastructure
{
    public class AngularRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            var rd = requestContext.RouteData;
            var action = rd.GetRequiredString("action");
            var controller = rd.GetRequiredString("controller");

            return new MvcHandler(requestContext);
        }
    }
}