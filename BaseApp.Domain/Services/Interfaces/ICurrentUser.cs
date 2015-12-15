using BaseApp.Data.Models.User;

namespace BaseApp.Domain.Services.Interfaces
{
    public interface ICurrentUser
    {
        ApplicationUserEntity User { get; } 
    }
}