using System.Web.Mvc;
using BaseApp.Web.Infrastructure.Controllers;

namespace BaseApp.Web.Controllers
{
    public class AngularExampleController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}