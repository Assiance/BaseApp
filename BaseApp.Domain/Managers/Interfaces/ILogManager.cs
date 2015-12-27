using BaseApp.Model.Models.Domain;

namespace BaseApp.Domain.Managers.Interfaces
{
    public interface ILogManager
    {
        void LogControllerAction(LogAction logAction);
    }
}