namespace Orleans.PlatformServices
{
    using System;
    using System.Reflection;
#if NETCORE
    using System.IO;
    using System.Runtime.Loader;
    using Microsoft.Extensions.DependencyModel;
#endif

    public class AssemblyLoader
    {
#if NETCORE
        private readonly AssemblyLoadContext assemblyLoadContext;
#endif

        public AssemblyLoader()
        {
#if NETCORE
            assemblyLoadContext = AssemblyLoadContext.Default;
#endif
        }

        public Assembly LoadFromBytes(byte[] rawAssembly, byte[] rawSymbolStore = null)
        {
            if (rawAssembly == null)
            {
                throw new ArgumentNullException(nameof(rawAssembly));
            }
            
#if NETCORE
            using (var assemblyStream = new MemoryStream(rawAssembly))
            {
                if (rawSymbolStore != null)
                {
                    using (var symbolStoreStream = new MemoryStream(rawSymbolStore))
                    {
                        return assemblyLoadContext.LoadFromStream(assemblyStream, symbolStoreStream);
                    }
                }
                else
                {
                    return assemblyLoadContext.LoadFromStream(assemblyStream);
                }
            }
#else
            return rawSymbolStore ==null ? Assembly.Load(rawAssembly) : Assembly.Load(rawAssembly, rawSymbolStore);
#endif
        }

        public Assembly LoadFromAssemblyPath(string assemblyPath)
        {
#if NETCORE
            var assembly = assemblyLoadContext.LoadFromAssemblyPath(assemblyPath);
#else
            var assembly = Assembly.LoadFrom(assemblyPath);
#endif

            return assembly;
        }
    }
}