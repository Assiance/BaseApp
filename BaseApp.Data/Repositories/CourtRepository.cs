using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BaseApp.Data.Contexts;
using BaseApp.Data.Models;
using BaseApp.Data.Repositories.Interfaces;
using BaseApp.Model.Models.Domain;
using StructureMap;

namespace BaseApp.Data.Repositories
{
    public class CourtRepository : ICourtRepository
    {
        private readonly IDataContext _dataContext;

        public CourtRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<Court> Courts
        {
            get
            {
                return _dataContext.GetQueryable<CourtEntity>().Select(x => new Court()
                {
                    Id = x.Id,
                    Name = x.Name
                });
            }
        }

        public Court CreateCourt(Court court)
        {
            var courtEntity = Mapper.Map<CourtEntity>(court);

            try
            {
                _dataContext.Upsert(courtEntity);
            }
            catch (Exception)
            {
                throw new ArgumentException(nameof(courtEntity));
            }

            return court;
        }

        public void UpdateCourt(Court court)
        {
            var courtEntity = Mapper.Map<CourtEntity>(court);

            try
            {
                _dataContext.Upsert(courtEntity);
            }
            catch (Exception)
            {
                throw new ArgumentException(nameof(courtEntity));
            }
        }

        public void DeleteCourt(Court court)
        {
            var courtEntity = Mapper.Map<CourtEntity>(court);

            try
            {
                _dataContext.Remove(courtEntity);
            }
            catch (Exception)
            {
                throw new ArgumentException(nameof(courtEntity));
            }
        }
    }
}
