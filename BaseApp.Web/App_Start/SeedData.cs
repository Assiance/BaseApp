using System.Linq;
using BaseApp.Domain.Services.Interfaces;
using BaseApp.Model.Models.Domain;
using BaseApp.Web.Infrastructure.Tasks;
using Microsoft.AspNet.Identity;

namespace BaseApp.Data
{
    public class SeedData : IRunAtStartup
    {
        private readonly IUserService _userService;

        public SeedData(IUserService userService)
        {
            //Todo: Recode this to use the repositories
            //Todo: Create SeedData for other Context
            _userService = userService;
        }

        public void Execute()
        {
            var passwordHash = new PasswordHasher();
            string password = passwordHash.HashPassword("test");
            if (!_userService.Users.Any())
            {
                _userService.CreateUser(new User()
                {
                    UserName = "TestUser",
                    Email = "Foo@Test.com",
                    EmailConfirmed = true,
                    PasswordHash = password
                });
            }
        }
    }
}