using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AutoMapper.QueryableExtensions;
using BaseApp.Domain.Managers.Interfaces;
using BaseApp.Model.Models.API;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Web.ViewModels
{
    public class CreateExampleRequest
    {
        public int ExampleId { get; set; }

        public CreateExampleRequest(int exampleId)
        {
            ExampleId = exampleId;
        }
    }
}