using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Domain.Managers.Interfaces
{
    public interface ICourtManager
    {
        IQueryable<Court> Courts { get; }
        Court CreateCourt(Court court);
        void UpdateCourt(Court court);
        void DeleteCourt(Court court);
    }
}
