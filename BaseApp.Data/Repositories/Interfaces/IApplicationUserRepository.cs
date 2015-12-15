using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Data.Repositories.Interfaces
{
    public interface IApplicationUserRepository
    {
        IQueryable<User> Users { get; }

        User CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
