using System.Collections.Generic;
using System.Web.Mvc;
using BaseApp.Domain;
using BaseApp.Domain.Managers.Interfaces;
using BaseApp.Domain.Services.Interfaces;
using BaseApp.Model.Models.Domain;
using BaseApp.Web.Infrastructure.Services.Interfaces;

namespace BaseApp.Web.Infrastructure.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        private IDictionary<string, object> _parameters;

        public ILogManager LogManager { get; set; }
        public ICurrentUserService CurrentUserService { get; set; }
        public IMemberManager MemberManager { get; set; }
        public string Description { get; set; }

        public LogAttribute(string description)
        {
            Description = description;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _parameters = filterContext.ActionParameters;

            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var description = Description;

            foreach (var keyValuePair in _parameters)
            {
                description = description.Replace("{" + keyValuePair.Key + "}", keyValuePair.Value.ToString());
            }

            var logAction = new LogAction(CurrentUserService.GetCurrentUser(), filterContext.ActionDescriptor.ActionName, 
                filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, description);

            LogManager.LogControllerAction(logAction);
        }
    }
}