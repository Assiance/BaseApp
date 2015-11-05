using System.Web.Mvc;
using AutoMapper;

using BaseApp.Domain.Models;
using BaseApp.Web.Infrastructure.Mapping;

namespace BaseApp.Web.ViewModels
{
    public class AnotherExampleViewModel : IHaveCustomMappings
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            // Maps the ViewModel Props to the Domain Model Props
            configuration.CreateMap<Example, AnotherExampleViewModel>()
                .ForMember(m => m.FullName, opt => opt.MapFrom(u => u.FirstName + ", " + u.LastName));
        }
    }
}