using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BaseApp.Domain.Managers.Interfaces;
using BaseApp.Model.Models.API;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Web.Controllers.APIs
{
    public class CourtsController : ApiController
    {
        private readonly ICourtManager _courtManager;

        public CourtsController(ICourtManager courtManager)
        {
            _courtManager = courtManager;
        }

        // GET: api/Courts
        public IQueryable<CourtApi> GetCourts()
        {
            return _courtManager.Courts.ProjectTo<CourtApi>();
        }

        // GET: api/Courts/5
        [ResponseType(typeof(CourtApi))]
        public IHttpActionResult GetCourt(int id)
        {
            Court court = _courtManager.Courts.FirstOrDefault(x => x.Id == id);
            if (court == null)
            {
                return NotFound();
            }

            var apiCourt = Mapper.Map<CourtApi>(court);

            return Ok(apiCourt);
        }

        // PUT: api/Courts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCourt(int id, Court court)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != court.Id)
            {
                return BadRequest();
            }

            try
            {
                _courtManager.UpdateCourt(court);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourtExists(id))
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

        // POST: api/Courts
        [ResponseType(typeof(CourtApi))]
        public IHttpActionResult PostCourt(Court court)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            court = _courtManager.CreateCourt(court);

            var apiCourt = Mapper.Map<CourtApi>(court);

            return CreatedAtRoute("DefaultApi", new { id = court.Id }, apiCourt);
        }

        // DELETE: api/Courts/5
        [ResponseType(typeof(CourtApi))]
        public IHttpActionResult DeleteCourt(int id)
        {
            Court court = _courtManager.Courts.FirstOrDefault(x => x.Id == id);
            if (court == null)
            {
                return NotFound();
            }

            _courtManager.DeleteCourt(court);

            return Ok(court);
        }

        private bool CourtExists(int id)
        {
            return _courtManager.Courts.Count(e => e.Id == id) > 0;
        }
    }
}