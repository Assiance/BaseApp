using BaseApp.Model.Models.Domain;

namespace BaseApp.Data.Services.Interfaces
{
    public interface IMembershipService
    {
        User GetById(string id);
    }
}