using System.Web.Mvc;
using BaseApp.Domain.Models;
using BaseApp.Web.Filters;
using BaseApp.Web.Infrastructure.Mapping;

namespace BaseApp.Web.ViewModels
{
    // IMapFrom will automatically map model props to the viewmodel props if the names match
    // Automapper will also automatically map associate props when named correctly. For instance. UserCreatedDate
    // will map to the CreatedDate prop in the User prop
    public class ExampleViewModel : IMapFrom<Example>, IHaveExampleSelectList
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public SelectListItem[] AvailableExamples { get; set; }        
    }
}