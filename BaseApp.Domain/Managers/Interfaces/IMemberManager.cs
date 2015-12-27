using BaseApp.Model.Models.Domain;

namespace BaseApp.Domain.Managers.Interfaces
{
    public interface IMemberManager
    {
        User GetUserById(string userId);
    }
}