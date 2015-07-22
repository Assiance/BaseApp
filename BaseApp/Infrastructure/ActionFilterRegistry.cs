using System;
using System.Web.Mvc;

using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.TypeRules;

namespace BaseApp.Infrastructure
{
    public class ActionFilterRegistry : Registry
    {
        public ActionFilterRegistry(Func<IContainer> containerFactory)
        {
            var index = typeof(ActionFilterRegistry).Namespace.IndexOf('.');
            var solutionName = typeof(ActionFilterRegistry).Namespace.Remove(index); 

            For<IFilterProvider>().Use(new StructureMapFilterProvider(containerFactory));

            Policies.SetAllProperties(x =>
                x.Matching(p =>
                p.DeclaringType.CanBeCastTo(typeof(ActionFilterAttribute)) &&
                p.DeclaringType.Namespace.StartsWith(solutionName) &&
                !p.PropertyType.IsPrimitive &&
                p.PropertyType != typeof(string)));
        }
    }
}