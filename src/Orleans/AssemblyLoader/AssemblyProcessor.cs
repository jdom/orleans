using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using Orleans.CodeGeneration;
using Orleans.Core;
using Orleans.Serialization;
using Orleans.Serialization.Registration;

namespace Orleans.Runtime
{
    /// <summary>
    /// The assembly processor.
    /// </summary>
    internal class AssemblyProcessor : IDisposable
    {
        private readonly ConcurrentBag<Assembly> pendingAssemblies = new ConcurrentBag<Assembly>();

        /// <summary>
        /// The collection of assemblies which have already been processed.
        /// </summary>
        private readonly HashSet<Assembly> processedAssemblies = new HashSet<Assembly>();

        /// <summary>
        /// The logger.
        /// </summary>
        private readonly Logger logger;
        
        /// <summary>
        /// The initialization lock.
        /// </summary>
        private readonly object initializationLock = new object();

        /// <summary>
        /// The type metadata cache.
        /// </summary>
        private readonly TypeMetadataCache typeCache;

        /// <summary>
        /// Whether or not this class has been initialized.
        /// </summary>
        private bool initialized;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyProcessor"/> class.
        /// </summary>
        /// <param name="typeCache">
        /// The type cache.
        /// </param>
        public AssemblyProcessor(TypeMetadataCache typeCache)
        {
            this.logger = LogManager.GetLogger("AssemblyProcessor");
            this.typeCache = typeCache;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            if (this.initialized)
            {
                return;
            }

            lock (this.initializationLock)
            {
                if (this.initialized)
                {
                    return;
                }

                // load the code generator before intercepting assembly loading
                CodeGeneratorManager.Initialize();

                AppDomain.CurrentDomain.AssemblyLoad += this.OnAssemblyLoad;

                // initialize discovery for already loaded assemblies.
                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    this.pendingAssemblies.Add(assembly);
                }

                this.initialized = true;
            }

            TryProcessPendingAssemblies();
        }

        /// <summary>
        /// Handles <see cref="AppDomain.AssemblyLoad"/> events.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="args">The event arguments.</param>
        private void OnAssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
#if !NETSTANDARD
            // If the assembly is loaded for reflection only avoid processing it.
            if (args.LoadedAssembly.ReflectionOnly)
            {
                return;
            }
#endif
            this.pendingAssemblies.Add(args.LoadedAssembly);
            this.TryProcessPendingAssemblies();
        }

        private void TryProcessPendingAssemblies()
        {
            if (!Monitor.TryEnter(this.processedAssemblies))
                return;

            var serializerFeature = new OrleansSerializationFeature();
            var grainInvokerFeature = new GrainInvokerFeature();
            var grainReferenceFeature = new GrainReferenceFeature();

            var serializerFeatureProvider = new OrleansSerializationFeatureProvider();
            var grainInvokerFeatureProvider = new GrainInvokerFeatureProvider();
            var grainReferenceFeatureProvider = new GrainReferenceFeatureProvider();

            try
            {
                List<Assembly> scannedAssembliesThisBatch = new List<Assembly>();

                while (!this.pendingAssemblies.IsEmpty)
                {
                    List<Assembly> assembliesToScan = new List<Assembly>();
                    Assembly assembly;
                    while (pendingAssemblies.TryTake(out assembly))
                    {
                        if (!this.processedAssemblies.Contains(assembly) && !scannedAssembliesThisBatch.Contains(assembly))
                        {
                            assembliesToScan.Add(assembly);
                        }
                    }

                    if (assembliesToScan.Count > 0)
                    {
                        var generated = CodeGeneratorManager.GenerateAndCacheCodeForAssemblies(assembliesToScan);
                        assembliesToScan = assembliesToScan.Union(generated).ToList();

                        var types = assembliesToScan.SelectMany(asm => TypeUtils.GetDefinedTypes(asm, logger)).ToList();

                        serializerFeatureProvider.PopulateFeature(types, serializerFeature);
                        grainInvokerFeatureProvider.PopulateFeature(types, grainInvokerFeature);
                        grainReferenceFeatureProvider.PopulateFeature(types, grainReferenceFeature);

                        scannedAssembliesThisBatch.AddRange(assembliesToScan);

                        // since the act of discovering could trigger more assembly loading, continue discovering
                    }
                }

                if (scannedAssembliesThisBatch.Count > 0)
                {

                    this.typeCache.RegisterGrainInvokers(grainInvokerFeature);
                    this.typeCache.RegisterGrainReferences(grainReferenceFeature);

                    SerializationManager.Register(serializerFeature);

                    foreach (var assembly in scannedAssembliesThisBatch)
                    {
                        this.processedAssemblies.Add(assembly);
                    }
                }
            }
            catch (Exception exception)
            {
                this.logger.Error(ErrorCode.Loader_AssemblyInspectError, "Failed to inspect assembly types. Exception: {0}.", exception);
            }
            finally
            {
                Monitor.Exit(this.processedAssemblies);
            }

            // re-check one last time after the lock was released, since there could have been a race condition
            if (!this.pendingAssemblies.IsEmpty)
            {
                TryProcessPendingAssemblies();
            }
        }

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        public void Dispose()
        {
            AppDomain.CurrentDomain.AssemblyLoad -= this.OnAssemblyLoad;
        }
    }
}
