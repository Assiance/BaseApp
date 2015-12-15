using System.Linq;
using BaseApp.Domain.Models.Domain;

namespace BaseApp.Domain.Services.Interfaces
{
    public interface IExampleService
    {
        IQueryable<Example> Examples { get; }

        Example CreateExample(Example example);
        void UpdateExample(Example example);
        void DeleteExample(Example example);
    }
}
