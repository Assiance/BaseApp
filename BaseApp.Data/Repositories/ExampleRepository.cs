using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BaseApp.Data.Contexts;
using BaseApp.Data.Models;
using BaseApp.Data.Repositories.Interfaces;
using BaseApp.Domain.Models.Domain;

namespace BaseApp.Data.Repositories
{
    public class ExampleRepository : IExampleRepository
    {
        private readonly IDataContext _dataContext;

        public IQueryable<Example> Examples => Mapper.Map<IQueryable<Example>>(_dataContext.GetQueryable<ExampleEntity>());

        public ExampleRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Example CreateExample(Example example)
        {
            var exampleEntity = Mapper.Map<ExampleEntity>(example);

            try
            {
                _dataContext.Upsert(exampleEntity);
            }
            catch (Exception)
            {
                throw new ArgumentException(nameof(exampleEntity));
            }

            return example;
        }

        public void UpdateExample(Example example)
        {
            var exampleEntity = Mapper.Map<ExampleEntity>(example);

            try
            {
                _dataContext.Upsert(exampleEntity);
            }
            catch (Exception)
            {
                throw new ArgumentException(nameof(exampleEntity));
            }
        }

        public void DeleteExample(Example example)
        {
            var exampleEntity = Mapper.Map<ExampleEntity>(example);

            try
            {
                _dataContext.Remove(exampleEntity);
            }
            catch (Exception)
            {
                throw new ArgumentException(nameof(exampleEntity));
            }
        }
    }
}
