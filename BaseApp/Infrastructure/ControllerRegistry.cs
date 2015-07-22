using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace BaseApp.Infrastructure
{
    public class ControllerRegistry : Registry
    {
        public ControllerRegistry()
        {
            Scan(scan =>
                    {
                        scan.TheCallingAssembly();
                        scan.With(new ControllerConvention());
                    });
        }
    }
}