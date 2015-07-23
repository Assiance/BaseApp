using BaseApp.Domain.Models.User;

namespace BaseApp.Web.Infrastructure
{
    public interface ICurrentUser
    {
        ApplicationUser User { get; } 
    }
}