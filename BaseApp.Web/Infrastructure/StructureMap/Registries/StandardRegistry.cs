using System.Linq;
using System.Reflection;
using BaseApp.Core;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace BaseApp.Web.Infrastructure.StructureMap.Registries
{
    public class StandardRegistry : Registry
    {
        public StandardRegistry()
        {
            var projects = AppAssemblies.AsEnumerable().Where(x => x != Assembly.GetExecutingAssembly() && x.FullName.StartsWith("BaseApp."));

            this.Scan(scan =>
                    {
                        foreach (var project in projects)
                        {
                            scan.Assembly(project);
                        }

                        scan.WithDefaultConventions();
                        scan.LookForRegistries();
                    });
        }
    }
}