using System.Linq;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Data.Repositories.Interfaces
{
    public interface IExampleRepository
    {
        IQueryable<Example> Examples { get; }

        Example CreateExample(Example example);
        void UpdateExample(Example example);
        void DeleteExample(Example example);
    }
}
