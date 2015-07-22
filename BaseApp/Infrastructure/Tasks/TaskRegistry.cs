using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace BaseApp.Infrastructure.Tasks
{
    public class TaskRegistry : Registry
    {
        public TaskRegistry()
        {
            var index = typeof(TaskRegistry).Namespace.IndexOf('.');
            var solutionName = typeof(TaskRegistry).Namespace.Remove(index); 

            Scan(
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