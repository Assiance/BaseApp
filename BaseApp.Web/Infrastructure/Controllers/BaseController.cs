using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using BaseApp.Web.Filters;
using Microsoft.Web.Mvc;

namespace BaseApp.Web.Infrastructure.Controllers
{
    [ExampleSelectListPopulator]
    public abstract class BaseController : Controller
    {
        protected ActionResult RedirectToAction<TController>(Expression<Action<TController>> action)
            where TController : Controller
        {
            return ControllerExtensions.RedirectToAction(this, action);
        }
    }
}