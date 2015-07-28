using System.Data.Entity;
using BaseApp.Domain.Models;
using BaseApp.Domain.Models.User;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BaseApp.DAL.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Example> Examples { get; set; }
        public DbSet<LogAction> Logs { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}