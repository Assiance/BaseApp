using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BaseApp.Core.Mapping;
using BaseApp.Domain.Managers.Interfaces;
using BaseApp.Model.Models.API;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Web.ViewModels
{
    public class CreateExampleRequest : IHaveCustomMappings
    {
        public int ExampleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            // Maps the ViewModel Props to the Domain Model Props
            configuration.CreateMap<Example, CreateExampleRequest>()
                .ForMember(m => m.FullName, opt => opt.MapFrom(u => u.FirstName + ", " + u.LastName));
        }
    }
}