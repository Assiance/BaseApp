using System.Data.Entity;
using BaseApp.Data.Models;
using BaseApp.Data.Models.User;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BaseApp.Data.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUserEntity>
    {
        public DbSet<ExampleEntity> Examples { get; set; }
        public DbSet<LogActionEntity> Logs { get; set; }
        public DbSet<CourtEntity> Courts { get; set; } 

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