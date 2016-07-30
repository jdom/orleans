using Orleans.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Orleans.Runtime
{
    public class PathBasedAssemblyCatalog : IAssemblyCatalog
    {
        private List<Assembly> catalog = new List<Assembly>();
        
        public List<Assembly> GetAssemblies()
        {
            return catalog;
        }

        public PathBasedAssemblyCatalog WithAssembly(string assemblyPath)
        {
            if (File.Exists(assemblyPath))
            {
                var location = new FileInfo(assemblyPath).FullName;
                if (!catalog.Any(a => a.Location == location))
                {
                    try
                    {
                        catalog.Add(Assembly.LoadFrom(location));
                    }
                    catch (Exception ex)
                    {
                        throw new InvalidOperationException($"Unable to load assembly {location}", ex);
                    }
                }
                return this;
            }
            else
            {
                throw new FileNotFoundException($"Can't find {assemblyPath}");
            }
        }
    }
}
