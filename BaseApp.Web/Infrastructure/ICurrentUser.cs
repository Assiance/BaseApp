using BaseApp.Web.Models;

namespace BaseApp.Web.Infrastructure
{
    public interface ICurrentUser
    {
        ApplicationUser User { get; } 
    }
}