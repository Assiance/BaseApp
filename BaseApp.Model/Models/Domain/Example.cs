using BaseApp.Core.Mapping;
using BaseApp.Model.Models.API;

namespace BaseApp.Model.Models.Domain
{
    public class Example : IMapFrom<ExampleApi>, IMapTo<ExampleApi>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
