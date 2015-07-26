using System.Web.Mvc;
using BaseApp.Web.Infrastructure.Security;

namespace BaseApp.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new RequireSecureConnectionFilter()); //Leave first in list
            filters.Add(new HandleErrorAttribute());
        }
    }
}
