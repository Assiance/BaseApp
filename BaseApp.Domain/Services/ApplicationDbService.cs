using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApp.Data.Contexts;
using BaseApp.Domain.Services.Interfaces;

namespace BaseApp.Domain.Services
{
    public class ApplicationDbService : IApplicationDbService
    {
        private readonly IDataContext _context;

        public ApplicationDbService(IDataContext context)
        {
            _context = context;
        }

        public DbContextTransaction BeginTransaction(IsolationLevel isolationLevel)
        {
            return _context.BeginTransaction(isolationLevel);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
