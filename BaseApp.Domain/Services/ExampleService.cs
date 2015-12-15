using System;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BaseApp.Data.Contexts;
using BaseApp.Data.Models;
using BaseApp.Domain.Models.Domain;
using BaseApp.Domain.Services.Interfaces;

namespace BaseApp.Domain.Services
{
    public class ExampleService : IExampleService
    {
        private readonly ApplicationDbContext _context;

        public IQueryable<Example> Examples
        {
            get
            {
                return _context.Examples.ProjectTo<Example>();
            }
        }

        public ExampleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Example CreateExample(Example example)
        {
            var entity = Mapper.Map<ExampleEntity>(example);

            _context.Examples.Add(entity);
            _context.SaveChanges();

            return example;
        }

        public void UpdateExample(Example example)
        {
            var entity = _context.Examples.First(x => x.Id == example.Id);

            Mapper.Map(example, entity);
            _context.SaveChanges();
        }

        public void DeleteExample(Example example)
        {
            var entity = _context.Examples.First(x => x.Id == example.Id);

            _context.Examples.Remove(entity);
            _context.SaveChanges();
        }
    }
}
