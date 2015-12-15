using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BaseApp.Data.Contexts;
using BaseApp.Data.Models.User;
using BaseApp.Domain.Models.Domain;
using BaseApp.Domain.Services.Interfaces;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public IQueryable<User> Users
        {
            get { return _context.Users.ProjectTo<User>(); }
        }

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public User CreateUser(User user)
        {
            var entity = Mapper.Map<ApplicationUserEntity>(user);

            _context.Users.Add(entity);
            _context.SaveChanges();

            return user;
        }

        public void UpdateUser(User user)
        {
            var entity = _context.Users.First(x => x.Id == user.Id);

            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            var entity = _context.Users.First(x => x.Id == user.Id);

            _context.Users.Remove(entity);
            _context.SaveChanges();
        }
    }
}
