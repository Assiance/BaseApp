using System.Linq;
using System.Web.Mvc;
using BaseApp.DAL.Contexts;

namespace BaseApp.Web.Infrastructure.Filters
{
    //Use EditorFor Template INSTEAD PluralSight Application Frameworks (Honeycutt) Demo: Editor Templates
    public class ExampleSelectListPopulatorAttribute : ActionFilterAttribute
    {
        public ApplicationDbContext Context { get; set; }

        //IF EXAMPLE WAS AN ENUM (Would be better to add enums to an editorFor template int the view)
        //private SelectListItem[] GetAvailableExamples1()
        //{
        //    return Enum.GetValues(typeof(Example))
        //            .Cast<Example>()
        //            .Select(x => new SelectListItem() { Text = x.ToString(), Value = x.ToString() })
        //            .ToArray();
        //}

        private SelectListItem[] GetAvailableExamples()
        {
            return Context.Examples.Select(x => new SelectListItem()
                                                    {
                                                        Text = x.FirstName,
                                                        Value = x.Id.ToString()
                                                    }).ToArray();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var viewResult = filterContext.Result as ViewResult;

            if (viewResult != null && viewResult.Model is IHaveExampleSelectList)
            {
                ((IHaveExampleSelectList)viewResult.Model).AvailableExamples = GetAvailableExamples();
            }
        }
    }

    public interface IHaveExampleSelectList
    {
        SelectListItem[] AvailableExamples { get; set; }
    }
}