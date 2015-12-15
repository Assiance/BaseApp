using System.Collections.Generic;
using System.Web.Mvc;
using BaseApp.Data.Contexts;
using BaseApp.Data.Models;
using BaseApp.Domain;
using BaseApp.Domain.Services.Interfaces;

namespace BaseApp.Web.Infrastructure.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        private IDictionary<string, object> _parameters;

        public ApplicationDbContext Context { get; set; }
        public ICurrentUser CurrentUser { get; set; }
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

            Context.Logs.Add(new LogActionEntity(CurrentUser.User, filterContext.ActionDescriptor.ActionName,
                filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, description));

            Context.SaveChanges();
        }
    }
}