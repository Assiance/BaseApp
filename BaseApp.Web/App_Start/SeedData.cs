using System.Data.Entity.Migrations;
using System.Linq;

using BaseApp.DAL.Contexts;
using BaseApp.Domain.Models.User;
using BaseApp.Web.Infrastructure.Tasks;
using Microsoft.AspNet.Identity;

namespace BaseApp.Web
{
    public class SeedData : IRunAtStartup
    {
        private readonly ApplicationDbContext _context;

        public SeedData(ApplicationDbContext context)
        {
            //Todo: Recode this to use the repositories
            //Todo: Create SeedData for other Context
            this._context = context;
        }

        public void Execute()
        {
            var passwordHash = new PasswordHasher();
            string password = passwordHash.HashPassword("test");
            if (!_context.Users.Any())
            {
                _context.Users.AddOrUpdate(new ApplicationUser()
                {
                    UserName = "TestUser",
                    PasswordHash = password
                });

                _context.SaveChanges();
            }
        }
    }
}