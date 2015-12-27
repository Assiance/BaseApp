using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BaseApp.Data.Contexts;
using BaseApp.Data.Models;
using BaseApp.Data.Repositories.Interfaces;
using BaseApp.Domain.Managers.Interfaces;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Domain.Managers
{
    public class ExampleManager : IExampleManager
    {
        private readonly IExampleRepository _exampleRepository;

        public IQueryable<Example> Examples
        {
            get
            {
                return _exampleRepository.Examples;
            }
        }

        public ExampleManager(IExampleRepository exampleRepository)
        {
            _exampleRepository = exampleRepository;
        }

        public Example CreateExample(Example example)
        {
            var created = _exampleRepository.CreateExample(example);

            return created;
        }

        public void UpdateExample(Example example)
        {
            _exampleRepository.UpdateExample(example);
        }

        public void DeleteExample(Example example)
        {
            _exampleRepository.DeleteExample(example);
        }
    }
}
