using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using BaseApp.Core.Mapping;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Data.Models
{
    [Table("Examples")]
    public class ExampleEntity : IMapFrom<Example>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}