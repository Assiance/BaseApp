using BaseApp.Core.Mapping;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Model.Models.API
{
    public class ExampleApi : IMapFrom<Example>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
