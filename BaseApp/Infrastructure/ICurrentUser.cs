using BaseApp.Models;

namespace BaseApp.Infrastructure
{
    public interface ICurrentUser
    {
        ApplicationUser User { get; } 
    }
}