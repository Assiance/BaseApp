using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Data.Repositories.Interfaces
{
    public interface ICourtRepository
    {
        IQueryable<Court> Courts { get; }

        Court CreateCourt(Court court);
        void UpdateCourt(Court court);
        void DeleteCourt(Court court);
    }
}
