using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper;
using BaseApp.Domain.Models.Domain;
using BaseApp.Domain.Services.Interfaces;
using BaseApp.Model.Models.API;

namespace BaseApp.Web.Controllers.APIs
{
    public class ExamplesController : ApiController
    {
        private readonly IExampleService _exampleService;

        public ExamplesController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        // GET: api/Examples
        public IQueryable<ExampleApi> GetExamples()
        {
            return Mapper.Map<IQueryable<ExampleApi>>(_exampleService.Examples);
        }

        // GET: api/Examples/5
        [ResponseType(typeof(ExampleApi))]
        public IHttpActionResult GetExample(int id)
        {
            Example example = _exampleService.Examples.FirstOrDefault(x => x.Id == id);
            if (example == null)
            {
                return NotFound();
            }

            var apiExample = Mapper.Map<ExampleApi>(example);

            return Ok(apiExample);
        }

        // PUT: api/Examples/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutExample(int id, Example example)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != example.Id)
            {
                return BadRequest();
            }

            try
            {
                _exampleService.UpdateExample(example);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExampleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Examples
        [ResponseType(typeof(ExampleApi))]
        public IHttpActionResult PostExample(Example example)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            example = _exampleService.CreateExample(example);

            var apiExample = Mapper.Map<ExampleApi>(example);

            return CreatedAtRoute("DefaultApi", new { id = example.Id }, apiExample);
        }

        // DELETE: api/Examples/5
        [ResponseType(typeof(ExampleApi))]
        public IHttpActionResult DeleteExample(int id)
        {
            Example example = _exampleService.Examples.FirstOrDefault(x => x.Id == id);
            if (example == null)
            {
                return NotFound();
            }

            _exampleService.DeleteExample(example);

            return Ok(example);
        }

        private bool ExampleExists(int id)
        {
            return _exampleService.Examples.Count(e => e.Id == id) > 0;
        }
    }
}