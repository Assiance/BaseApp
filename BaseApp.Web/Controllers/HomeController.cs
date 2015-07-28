using System.Web.Mvc;
using BaseApp.Web.Infrastructure.Controllers;

namespace BaseApp.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
