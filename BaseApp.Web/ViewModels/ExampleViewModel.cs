﻿using System.Web.Mvc;
using BaseApp.Core.Mapping;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Web.ViewModels
{
    // IMapFrom will automatically map model props to the viewmodel props if the names match
    // Automapper will also automatically map associate props when named correctly. For instance. UserCreatedDate
    // will map to the CreatedDate prop in the User prop
    public class ExampleViewModel : IMapFrom<Example>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }        
    }
}