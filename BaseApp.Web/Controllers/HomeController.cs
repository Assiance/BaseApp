using System.Web.Mvc;
using BaseApp.Web.Infrastructure.Controllers;

namespace BaseApp.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }
    }
}
