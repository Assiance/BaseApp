using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using BaseApp.Data.Contexts;
using BaseApp.Data.Models.User;
using BaseApp.Data.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using StructureMap.Pipeline;

namespace BaseApp.Data.Registries
{
    public class DataRegistry : Registry
    {
        public DataRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });

            For<DbContext>().Use<ApplicationDbContext>();

            For<IUserStore<ApplicationUserEntity>>().Use<UserStore<ApplicationUserEntity>>();
            For<UserManager<ApplicationUserEntity, string>>().Use<ApplicationUserRepository>();
            For<IAuthenticationManager>().Use(context => context.GetInstance<IOwinContext>().Authentication);

            For<IdentityFactoryOptions<ApplicationUserRepository>>().Use(c => new IdentityFactoryOptions<ApplicationUserRepository>()
            {
                DataProtectionProvider = new Microsoft.Owin.Security.DataProtection.DpapiDataProtectionProvider("BaseApp")
            });

            //For().Use(x => x.)

            //any spefic implementation   
            //builder.RegisterType<UserStore<ApplicationUserEntity>>().As<IUserStore<ApplicationUserEntity>>().InstancePerLifetimeScope();
            //builder.RegisterType<ApplicationUserRepository>().AsSelf().As<UserManager<ApplicationUserEntity, string>>().InstancePerLifetimeScope();

            //builder.Register<IdentityFactoryOptions<ApplicationUserRepository>>(c => new IdentityFactoryOptions<ApplicationUserRepository>()
            //{
            //    DataProtectionProvider = new Microsoft.Owin.Security.DataProtection.DpapiDataProtectionProvider("GlobalKnowledge")
            //});
        }
    }
}
