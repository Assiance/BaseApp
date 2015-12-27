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
    public class LogManager : ILogManager
    {
        private readonly ILogActionRepository _logActionRepository;

        public LogManager(ILogActionRepository logActionRepository)
        {
            _logActionRepository = logActionRepository;
        }

        public void LogControllerAction(LogAction logAction)
        {
            _logActionRepository.LogTheAction(logAction);
        }
    }
}
