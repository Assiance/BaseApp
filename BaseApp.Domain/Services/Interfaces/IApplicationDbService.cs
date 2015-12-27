using System.Data;
using System.Data.Entity;
using BaseApp.Data.Contexts;

namespace BaseApp.Domain.Services.Interfaces
{
    public interface IApplicationDbService
    {
        DbContextTransaction BeginTransaction(IsolationLevel isolationLevel);
    }
}