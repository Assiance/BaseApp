using BaseApp.Model.Models.Domain;

namespace BaseApp.Data.Repositories.Interfaces
{
    public interface ILogActionRepository
    {
        void LogTheAction(LogAction logAction);
    }
}