using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BaseApp.Data.Contexts;
using BaseApp.Data.Entities.User;
using BaseApp.Data.Repositories;
using BaseApp.Data.Services.Interfaces;
using BaseApp.Model.Models.Domain;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace BaseApp.Data.Services
{
    public class MembershipService : SignInManager<ApplicationUserEntity, string>, IMembershipService
    {
        private readonly IDataContext _dataContext;

        public MembershipService(IDataContext dataContext, ApplicationUserRepository userRepository, IAuthenticationManager authenticationManager)
            : base(userRepository, authenticationManager)
        {
            _dataContext = dataContext;
        }

        private IQueryable<ApplicationUserEntity> UsersCompleteQuery
        {
            get
            {
                return UserManager.Users;
            }  
        } 

        public User GetById(string id)
        {
            var user = UsersCompleteQuery.FirstOrDefault(x => x.Id == id);

            if (user == null)
            {
                return null;
            }

            return Mapper.Map<User>(user);
        }
    }
}
