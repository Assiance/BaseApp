using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace BaseApp.Web.Infrastructure
{
    public class StandardRegistry : Registry
    {
        public StandardRegistry()
        {
            this.Scan(scan =>
                    {
                        scan.TheCallingAssembly();
                        scan.WithDefaultConventions();
                    });
        }
    }
}