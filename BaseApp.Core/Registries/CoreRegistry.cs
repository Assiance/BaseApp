﻿using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace BaseApp.Core.Registries
{
    public class CoreRegistry : Registry
    {
        public CoreRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();

            });

            //any spefic implementation   
        }
    }
}
