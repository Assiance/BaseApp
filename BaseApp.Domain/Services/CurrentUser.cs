using System.Linq;
using System.Security.Principal;
using BaseApp.Data.Contexts;
using BaseApp.Data.Models.User;
using BaseApp.Domain.Services.Interfaces;
using Microsoft.AspNet.Identity;

namespace BaseApp.Domain.Services
{
    public class CurrentUser : ICurrentUser
    {
        private readonly IIdentity _identity;
        private readonly ApplicationDbContext _context;

        private ApplicationUserEntity _user;

        public CurrentUser(IIdentity identity, ApplicationDbContext context)
        {
            _identity = identity;
            _context = context;
        }

        public ApplicationUserEntity User
        {
            get
            {
                return _user ?? (_user = _context.Users.FirstOrDefault(x => x.Id == _identity.GetUserId()));
            }
        }
    }
}