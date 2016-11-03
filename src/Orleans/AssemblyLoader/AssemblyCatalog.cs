using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Orleans.Runtime
{
    public class AssemblyCatalog : IAssemblyCatalog
    {
        private Assembly[] output;
        private HashSet<AssemblyName> input = new HashSet<AssemblyName>();
        private Logger logger;

        public AssemblyCatalog()
        {
            logger = LogManager.GetLogger("AssemblyCatalog", LoggerType.Provider);
        }

        public List<string> ExcludedAssemblies { get; } = new List<string>();

        public List<Assembly> GetAssemblies()
        {
            if (output == null)
            {
                HashSet<Assembly> assemblies = new HashSet<Assembly>();
                if (input.Count == 0)
                {
                    // input.Add(Assembly.GetExecutingAssembly().GetName());

                    // optionally load all DLLs from executing directory, for back compat
                    TryLoadFromExecutingFolder(assemblies);
                }
                else
                {
                    foreach (var assemblyName in input)
                    {
                        // should not fail, since this assembly is already loaded
                        assemblies.Add(Assembly.Load(assemblyName));
                    }
                }

                assemblies.Add(typeof(Exception).GetTypeInfo().Assembly);
                assemblies.Add(typeof(AssemblyCatalog).GetTypeInfo().Assembly);

                foreach (var assembly in assemblies.ToList())
                {
                    LoadDependencies(assemblies, assembly);
                }
                output = assemblies.ToArray();
            }

            return output.ToList();
        }

        private void TryLoadFromExecutingFolder(HashSet<Assembly> assemblies)
        {
#if NETSTANDARD
            string path = AppContext.BaseDirectory;
#else
            string path = Path.GetDirectoryName(new Uri((this.GetType().Assembly).CodeBase).LocalPath);
#endif
            var assemblyFiles = Directory.EnumerateFiles(path, "*.dll");
            var assemblyNames = assemblyFiles.Select(Path.GetFileNameWithoutExtension).ToList();
            foreach (var assemblyName in assemblyNames.Select(x => new AssemblyName(x)))
            {
                try
                {
                    if (!ShouldScanAssembly(assemblyName))
                    {
                        // Stop recursively loading dependencies
                        return;
                    }
                    assemblies.Add(Assembly.Load(assemblyName));
                    logger.Info($"Loaded {assemblyName} from working directory.");
                }
                catch (Exception ex)
                {
                    logger.Warn(ErrorCode.Provider_AssemblyLoadError, $"Unable to load assembly {assemblyName} from working directory. This is harmless. Skipping.", ex);
                }
            }
        }

        public AssemblyCatalog WithAssembly(string assemblyName)
        {
            return WithAssembly(new AssemblyName(assemblyName));
        }

        public AssemblyCatalog WithAssembly(AssemblyName assemblyName)
        {
            try
            {
                var assembly = Assembly.Load(assemblyName);
                input.Add(assembly.GetName());
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Unable to load assembly: {assemblyName}", ex);
            }
            
            return this;            
        }

        private void LoadDependencies(HashSet<Assembly> loadedAssemblies, Assembly fromAssembly)
        {
            foreach (var reference in fromAssembly.GetReferencedAssemblies())
            {
                try
                {
                    if (!ShouldScanAssembly(reference))
                    {
                        // Stop recursively loading dependencies
                        return;
                    }

                    var asm = Assembly.Load(reference);
                    if (loadedAssemblies.Add(asm))
                    {
                        logger.Info($"Loaded {reference} which is a dependency of {fromAssembly.GetName().Name}.");
                        LoadDependencies(loadedAssemblies, asm);
                    }
                }
                catch (Exception ex)
                {
                    logger.Warn(ErrorCode.Provider_AssemblyLoadError, $"Unable to load assembly {reference.FullName} referenced by {fromAssembly.FullName}. This is harmless. Skipping.", ex);
                }
            }
        }

        private bool ShouldScanAssembly(AssemblyName assemblyName)
        {
            // this can be as complex as we want, such as supporting wildcards as in Tests.*.Mocks
            // By the way, this acts on the assembly name, and not paths.
            return !this.ExcludedAssemblies.Contains(assemblyName.Name);
        }
    }
}
