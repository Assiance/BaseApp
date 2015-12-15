using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApp.Data.Contexts;
using BaseApp.Domain.Managers.Interfaces;

namespace BaseApp.Domain.Managers
{
    public class ExampleManager : IExampleManager
    {
        private readonly ApplicationDbContext _dataContext;

        public ExampleManager(ApplicationDbContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
