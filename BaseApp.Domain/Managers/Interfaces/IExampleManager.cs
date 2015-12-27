using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Domain.Managers.Interfaces
{
    public interface IExampleManager
    {
        IQueryable<Example> Examples { get; }
        Example CreateExample(Example example);
        void UpdateExample(Example example);
        void DeleteExample(Example example);
    }
}
