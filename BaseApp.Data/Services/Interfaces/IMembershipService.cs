using System.Threading.Tasks;
using BaseApp.Model.Models.Domain;
using BaseApp.Model.Models.Domain.Authentication;

namespace BaseApp.Data.Services.Interfaces
{
    public interface IMembershipService
    {
        User GetById(string id);
        Task<RegistrationResult> RegisterAndSignInAsync(Registration registration);
        Task<User> GetUserByEmailAsync(string email);
    }
}