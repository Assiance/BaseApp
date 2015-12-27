using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BaseApp.Data.Contexts;
using BaseApp.Data.Models;
using BaseApp.Data.Models.User;
using BaseApp.Data.Repositories.Interfaces;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Data.Repositories
{
    public class LogActionRepository : ILogActionRepository
    {
        private readonly IDataContext _dataContext;

        public LogActionRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void LogTheAction(LogAction logAction)
        {
            var logActionEntity = Mapper.Map<LogActionEntity>(logAction);

            try
            {
                _dataContext.Upsert(logActionEntity);
            }
            catch (Exception)
            {
                throw new ArgumentException(nameof(logActionEntity));
            }
        }
    }
}
