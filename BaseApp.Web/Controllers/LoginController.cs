using System.Web.Mvc;
using BaseApp.Web.Infrastructure.Controllers;

namespace BaseApp.Web.Controllers
{
    public class LoginController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}