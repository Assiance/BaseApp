using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApp.Data.Repositories.Interfaces;
using BaseApp.Domain.Managers.Interfaces;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Domain.Managers
{
    public class CourtManager : ICourtManager
    {
        private readonly ICourtRepository _courtRepository;

        public CourtManager(ICourtRepository courtRepository)
        {
            _courtRepository = courtRepository;
        }

        public IQueryable<Court> Courts
        {
            get { return _courtRepository.Courts; }
        }

        public Court CreateCourt(Court court)
        {
            return _courtRepository.CreateCourt(court);
        }

        public void UpdateCourt(Court court)
        {
            _courtRepository.UpdateCourt(court);
        }

        public void DeleteCourt(Court court)
        {
            _courtRepository.DeleteCourt(court);
        }
    }
}
