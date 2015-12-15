using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BaseApp.Data.Contexts;
using BaseApp.Data.Models;
using BaseApp.Data.Models.User;
using BaseApp.Data.Repositories.Interfaces;
using BaseApp.Domain.Models.Domain;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Data.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly IDataContext _dataContext;

        public IQueryable<User> Users => Mapper.Map<IQueryable<User>>(_dataContext.GetQueryable<ApplicationUserEntity>());

        public ApplicationUserRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public User CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
