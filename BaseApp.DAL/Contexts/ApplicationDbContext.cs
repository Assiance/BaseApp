using BaseApp.Domain.Models.User;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BaseApp.DAL.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<BaseApp.Domain.Models.Example> Examples { get; set; }
    }
}