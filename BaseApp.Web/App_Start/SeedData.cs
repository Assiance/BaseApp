using System.Linq;

using BaseApp.Web.Models;

namespace BaseApp.Web
{
    public class SeedData
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
            //if (!_context.Users.Any())
            //{
            //    _context.Users.Add(new ApplicationUser()
            //    {
            //       UserName = "TestUser"
            //    });

            //    _context.SaveChanges();
            //}
        }
    }
}