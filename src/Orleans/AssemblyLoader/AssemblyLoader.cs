using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Orleans.Runtime
{
    public class AssemblyLoader
    {
        public IAssemblyCatalog AssemblyCatalog { get; private set; }

        private AssemblyLoader(IAssemblyCatalog catalog)
        {
            AssemblyCatalog = catalog;            
        }

        internal static AssemblyLoader NewAssemblyLoader(IAssemblyCatalog catalog)
        {
            if (catalog == null) throw new ArgumentNullException(nameof(catalog));

            var loader =  new AssemblyLoader(catalog);

            AssemblyProcessor.ProcessAssemblies(loader.AssemblyCatalog.GetAssemblies());

            return loader;
        }

        public static T TryLoadAndCreateInstance<T>(string assemblyName, Logger logger) where T : class
        {
            try
            {
                var assembly = Assembly.Load(new AssemblyName(assemblyName));
                var foundType =
                    TypeUtils.GetTypes(
                        assembly,
                        type =>
                        typeof(T).IsAssignableFrom(type) && !type.GetTypeInfo().IsInterface
                        && type.GetConstructor(Type.EmptyTypes) != null, logger).FirstOrDefault();
                if (foundType == null)
                {
                    return null;
                }

                return (T)Activator.CreateInstance(foundType, true);
            }
            catch (FileNotFoundException exception)
            {
                logger.Warn(ErrorCode.Loader_TryLoadAndCreateInstance_Failure, exception.Message, exception);
                return null;
            }
            catch (Exception exc)
            {
                logger.Error(ErrorCode.Loader_TryLoadAndCreateInstance_Failure, exc.Message, exc);
                throw;
            }
        }

        public static T LoadAndCreateInstance<T>(string assemblyName, Logger logger) where T : class
        {
            try
            {
                var assembly = Assembly.Load(new AssemblyName(assemblyName));
                var foundType = TypeUtils.GetTypes(assembly, type => typeof(T).IsAssignableFrom(type), logger).First();

                return (T)Activator.CreateInstance(foundType, true);
            }
            catch (Exception exc)
            {
                logger.Error(ErrorCode.Loader_LoadAndCreateInstance_Failure, exc.Message, exc);
                throw;
            }
        }
    }
}
