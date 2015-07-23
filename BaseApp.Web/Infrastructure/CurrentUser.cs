using System.Security.Principal;

using BaseApp.Web.Models;

using Microsoft.AspNet.Identity;

namespace BaseApp.Web.Infrastructure
{
    public class CurrentUser : ICurrentUser
    {
        private readonly IIdentity _identity;
        private readonly ApplicationDbContext _context;

        private ApplicationUser _user;

        public CurrentUser(IIdentity identity, ApplicationDbContext context)
        {
            this._identity = identity;
            this._context = context;
        }

        public ApplicationUser User
        {
            get
            {
                return this._user ?? (this._user = this._context.Users.Find(this._identity.GetUserId()));
            }
        }
    }
}