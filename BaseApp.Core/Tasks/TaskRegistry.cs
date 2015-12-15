using BaseApp.Web.Infrastructure.Tasks;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace BaseApp.Core.Tasks
{
    public class TaskRegistry : Registry
    {
        public TaskRegistry()
        {
            var solutionName = typeof(Core).Namespace;

            this.Scan(
                scan =>
                    {
                        scan.AssembliesFromApplicationBaseDirectory(
                            a => a.FullName.StartsWith(solutionName));
                        scan.AddAllTypesOf<IRunAtInit>();
                        scan.AddAllTypesOf<IRunAtStartup>();
                        scan.AddAllTypesOf<IRunOnEachRequest>();
                        scan.AddAllTypesOf<IRunOnError>();
                        scan.AddAllTypesOf<IRunAfterEachRequest>();
                    });
        }
    }
}