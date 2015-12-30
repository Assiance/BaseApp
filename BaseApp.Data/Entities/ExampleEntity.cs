using System.ComponentModel.DataAnnotations.Schema;
using BaseApp.Core.Mapping;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Data.Entities
{
    [Table("Examples")]
    public class ExampleEntity : IMapFrom<Example>, IMapTo<Example>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}