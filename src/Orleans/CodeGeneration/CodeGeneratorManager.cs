using System.Collections;

namespace Orleans.CodeGeneration
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reflection;
    using Orleans.Runtime;
    using System.Linq;

    /// <summary>
    /// Methods for invoking code generation.
    /// </summary>
    internal static class CodeGeneratorManager
    {
        private static readonly object initializationLock = new object();
        private static bool initialized;

        /// <summary>
        /// The name of the code generator assembly.
        /// </summary>
        private const string CodeGenAssemblyName = "OrleansCodeGenerator";

        /// <summary>
        /// The log.
        /// </summary>
        private static readonly Logger Log = LogManager.GetLogger("CodeGenerator");

        /// <summary>
        /// Empty generated assemblies.
        /// </summary>
        private static readonly ReadOnlyDictionary<string, GeneratedAssembly> EmptyGeneratedAssemblies =
            new ReadOnlyDictionary<string, GeneratedAssembly>(new Dictionary<string, GeneratedAssembly>());

        /// <summary>
        /// The runtime code generator.
        /// </summary>
        private static IRuntimeCodeGenerator codeGeneratorInstance;

        /// <summary>
        /// The code generator cache.
        /// </summary>
        private static ICodeGeneratorCache codeGeneratorCacheInstance;

        /// <summary>
        /// Loads the code generator on demand
        /// </summary>
        public static void Initialize()
        {
            if (!initialized)
            {
                lock (initializationLock)
                {
                    if (!initialized)
                    {
                        codeGeneratorInstance = LoadCodeGenerator();
                        codeGeneratorCacheInstance = codeGeneratorInstance as ICodeGeneratorCache;
                        initialized = true;
                    }
                }
            }
        }

        /// <summary>
        /// Ensures code for the specified loaded assemblies has been generated and loaded.
        /// </summary>
        public static ICollection<Assembly> GenerateAndCacheCodeForAssemblies(ICollection<Assembly> inputs)
        {
            if (codeGeneratorInstance != null)
            {
                ICollection<Assembly> result;
                if (codeGeneratorInstance.TryGenerateAndLoadForAssemblies(inputs, out result))
                {
                    return result;
                }
            }

            return new List<Assembly>();
        }

        /// <summary>
        /// Returns the collection of generated assemblies as pairs of target assembly name to raw assembly bytes.
        /// </summary>
        /// <returns>The collection of generated assemblies.</returns>
        public static IDictionary<string, GeneratedAssembly> GetGeneratedAssemblies()
        {
            if (codeGeneratorCacheInstance != null)
            {
                // do not return derived instances of GeneratedAssembly
                return codeGeneratorCacheInstance.GetGeneratedAssemblies().ToDictionary(x => x.Key, x => new GeneratedAssembly(x.Value));
            }

            return EmptyGeneratedAssemblies;
        }

        /// <summary>
        /// Adds a pre-generated assembly to the assembly cache.
        /// </summary>
        /// <param name="targetAssemblyName">
        /// The name of the assembly the provided <paramref name="generatedAssembly"/> targets.
        /// </param>
        /// <param name="generatedAssembly">
        /// The generated assembly.
        /// </param>
        public static void AddGeneratedAssembly(string targetAssemblyName, GeneratedAssembly generatedAssembly)
        {
            if (codeGeneratorCacheInstance != null)
            {
                codeGeneratorCacheInstance.AddGeneratedAssembly(targetAssemblyName, generatedAssembly);
            }
            else
            {
                Log.Warn(
                    ErrorCode.CodeGenDllMissing,
                    "CodeGenerationManager.AddCachedAssembly called but no code generator has been loaded.");
            }
        }

        /// <summary>
        /// Loads the code generator.
        /// </summary>
        /// <returns>The code generator.</returns>
        private static IRuntimeCodeGenerator LoadCodeGenerator()
        {
            IRuntimeCodeGenerator result = AssemblyLoader.TryLoadAndCreateInstance<IRuntimeCodeGenerator>(CodeGenAssemblyName, Log);
            if (result == null)
            {
                Log.Warn(
                    ErrorCode.CodeGenDllMissing,
                    "Code generator assembly (" + CodeGenAssemblyName + ".dll) not present.");
            }

            return result;
        }
    }
}
