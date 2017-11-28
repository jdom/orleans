using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Orleans.Runtime;
using Orleans.Runtime.Configuration;
using Orleans.Serialization;
using Orleans.Streams;
using Orleans.TestingHost.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Memory;

namespace Orleans.TestingHost
{

    /// <summary>
    /// A host class for local testing with Orleans using in-process silos. 
    /// Runs a Primary and optionally secondary silos in separate app domains, and client in the main app domain.
    /// Additional silos can also be started in-process on demand if required for particular test cases.
    /// </summary>
    /// <remarks>
    /// Make sure that your test project references your test grains and test grain interfaces 
    /// projects, and has CopyLocal=True set on those references [which should be the default].
    /// </remarks>
    public class TestCluster2
    {
        private int startedInstances;

        /// <summary>
        /// Primary silo handle
        /// </summary>
        public SiloHandle2 Primary { get; private set; }

        /// <summary>
        /// List of handles to the secondary silos
        /// </summary>
        public IReadOnlyList<SiloHandle2> SecondarySilos => this.additionalSilos;

        private readonly List<SiloHandle2> additionalSilos = new List<SiloHandle2>();
        

        private readonly StringBuilder log = new StringBuilder();

        /// <summary>
        /// Id of the cluster
        /// </summary>
        public string ClusterId => this.options.ClusterId;

        /// <summary>
        /// The internal client interface.
        /// </summary>
        internal IInternalClusterClient InternalClient { get; private set; }

        /// <summary>
        /// The client.
        /// </summary>
        public IClusterClient Client => this.InternalClient;

        /// <summary>
        /// GrainFactory to use in the tests
        /// </summary>
        public IGrainFactory GrainFactory => this.Client;

        /// <summary>
        /// The client-side <see cref="StreamProviderManager"/>.
        /// </summary>
        public IStreamProviderManager StreamProviderManager { get; private set; }

        /// <summary>
        /// GrainFactory to use in the tests
        /// </summary>
        internal IInternalGrainFactory InternalGrainFactory => this.InternalClient;

        /// <summary>
        /// Client-side <see cref="IServiceProvider"/> to use in the tests.
        /// </summary>
        public IServiceProvider ServiceProvider => this.Client.ServiceProvider;
        
        /// <summary>
        /// SerializationManager to use in the tests
        /// </summary>
        public SerializationManager SerializationManager { get; private set; }

        private TestClusterOptions2 options;

        /// <summary>
        /// Configure the default Primary test silo, plus client in-process.
        /// </summary>
        public TestCluster2()
            : this(new TestClusterOptions2())
        {
        }

        /// <summary>
        /// Configures the test cluster plus client in-process.
        /// </summary>
        public TestCluster2(TestClusterOptions2 options)
        {
            this.options = options;
        }

        /// <summary>
        /// Deploys the cluster using the specified configuration and starts the client in-process.
        /// It will start the number of silos defined in <see cref="TestClusterOptions2.InitialSilosCount"/>.
        /// </summary>
        public void Deploy()
        {
            this.DeployAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deploys the cluster using the specified configuration and starts the client in-process.
        /// </summary>
        public async Task DeployAsync()
        {
            if (this.Primary != null || this.additionalSilos.Count > 0) throw new InvalidOperationException("Cluster host already deployed.");

            AppDomain.CurrentDomain.UnhandledException += ReportUnobservedException;

            try
            {
                string startMsg = "----------------------------- STARTING NEW UNIT TEST SILO HOST: " + GetType().FullName + " -------------------------------------";
                WriteLog(startMsg);
                await InitializeAsync();
            }
            catch (TimeoutException te)
            {
                FlushLogToConsole();
                throw new TimeoutException("Timeout during test initialization", te);
            }
            catch (Exception ex)
            {
                StopAllSilos();

                Exception baseExc = ex.GetBaseException();
                FlushLogToConsole();

                if (baseExc is TimeoutException)
                {
                    throw new TimeoutException("Timeout during test initialization", ex);
                }

                // IMPORTANT:
                // Do NOT re-throw the original exception here, also not as an internal exception inside AggregateException
                // Due to the way MS tests works, if the original exception is an Orleans exception,
                // it's assembly might not be loaded yet in this phase of the test.
                // As a result, we will get "MSTest: Unit Test Adapter threw exception: Type is not resolved for member XXX"
                // and will loose the original exception. This makes debugging tests super hard!
                // The root cause has to do with us initializing our tests from Test constructor and not from TestInitialize method.
                // More details: http://dobrzanski.net/2010/09/20/mstest-unit-test-adapter-threw-exception-type-is-not-resolved-for-member/
                //throw new Exception(
                //    string.Format("Exception during test initialization: {0}",
                //        LogFormatter.PrintException(baseExc)));
                throw;
            }
        }

        /// <summary>
        /// Get the list of current active silos.
        /// </summary>
        /// <returns>List of current silos.</returns>
        public IEnumerable<SiloHandle2> GetActiveSilos()
        {
            WriteLog("GetActiveSilos: Primary={0} + {1} Additional={2}",
                Primary, additionalSilos.Count, Runtime.Utils.EnumerableToString(additionalSilos));

            if (Primary?.IsActive == true) yield return Primary;
            if (additionalSilos.Count > 0)
                foreach (var s in additionalSilos)
                    if (s?.IsActive == true)
                        yield return s;
        }

        /// <summary>
        /// Find the silo handle for the specified silo address.
        /// </summary>
        /// <param name="siloAddress">Silo address to be found.</param>
        /// <returns>SiloHandle2 of the appropriate silo, or <c>null</c> if not found.</returns>
        public SiloHandle2 GetSiloForAddress(SiloAddress siloAddress)
        {
            var activeSilos = GetActiveSilos().ToList();
            var ret = activeSilos.FirstOrDefault(s => s.SiloAddress.Equals(siloAddress));
            return ret;
        }

        /// <summary>
        /// Wait for the silo liveness sub-system to detect and act on any recent cluster membership changes.
        /// </summary>
        /// <param name="didKill">Whether recent membership changes we done by graceful Stop.</param>
        public async Task WaitForLivenessToStabilizeAsync(bool didKill = false)
        {
            // TODO: read from the cluster
            var globalConfiguration = new GlobalConfiguration(); //this.ClusterConfiguration.Globals
            TimeSpan stabilizationTime = GetLivenessStabilizationTime(globalConfiguration, didKill);
            WriteLog(Environment.NewLine + Environment.NewLine + "WaitForLivenessToStabilize is about to sleep for {0}", stabilizationTime);
            await Task.Delay(stabilizationTime);
            WriteLog("WaitForLivenessToStabilize is done sleeping");
        }

        /// <summary>
        /// Get the timeout value to use to wait for the silo liveness sub-system to detect and act on any recent cluster membership changes.
        /// <seealso cref="WaitForLivenessToStabilizeAsync"/>
        /// </summary>
        public static TimeSpan GetLivenessStabilizationTime(GlobalConfiguration global, bool didKill = false)
        {
            TimeSpan stabilizationTime = TimeSpan.Zero;
            if (didKill)
            {
                // in case of hard kill (kill and not Stop), we should give silos time to detect failures first.
                stabilizationTime = TestingUtils.Multiply(global.ProbeTimeout, global.NumMissedProbesLimit);
            }
            if (global.UseLivenessGossip)
            {
                stabilizationTime += TimeSpan.FromSeconds(5);
            }
            else
            {
                stabilizationTime += TestingUtils.Multiply(global.TableRefreshTimeout, 2);
            }
            return stabilizationTime;
        }

        /// <summary>
        /// Start an additional silo, so that it joins the existing cluster.
        /// </summary>
        /// <returns>SiloHandle2 for the newly started silo.</returns>
        public SiloHandle2 StartAdditionalSilo()
        {
            return this.StartAdditionalSilos(1).GetAwaiter().GetResult().Single();
        }

        /// <summary>
        /// Start a number of additional silo, so that they join the existing cluster.
        /// </summary>
        /// <param name="silosToStart">Number of silos to start.</param>
        /// <returns>List of SiloHandles for the newly started silos.</returns>
        public async Task<List<SiloHandle2>> StartAdditionalSilos(int silosToStart)
        {
            var instances = new List<SiloHandle2>();
            if (silosToStart > 0)
            {
                var siloStartTasks = Enumerable.Range(this.startedInstances, silosToStart)
                    .Select(instanceNumber => Task.Run(() => StartOrleansSilo((short)instanceNumber, this.options))).ToArray();

                try
                {
                    await Task.WhenAll(siloStartTasks);
                }
                catch (Exception)
                {
                    this.additionalSilos.AddRange(siloStartTasks.Where(t => t.Exception == null).Select(t => t.Result));
                    throw;
                }

                instances.AddRange(siloStartTasks.Select(t => t.Result));
                this.additionalSilos.AddRange(instances);
            }

            return instances;
        }

        /// <summary>
        /// Stop any additional silos, not including the default Primary silo.
        /// </summary>
        public void StopSecondarySilos()
        {
            foreach (var instance in this.additionalSilos.ToList())
            {
                StopSilo(instance);
            }
        }

        /// <summary>
        /// Stops the default Primary silo.
        /// </summary>
        public void StopPrimarySilo()
        {
            if (Primary == null) throw new InvalidOperationException("There is no primary silo");
            StopClusterClient();
            StopSilo(Primary);
        }

        private void StopClusterClient()
        {
            try
            {
                this.InternalClient?.Close().GetAwaiter().GetResult();
            }
            catch (Exception exc)
            {
                WriteLog("Exception Uninitializing grain client: {0}", exc);
            }
            finally
            {
                this.InternalClient?.Dispose();
                this.InternalClient = null;
            }
        }

        /// <summary>
        /// Stop all current silos.
        /// </summary>
        public void StopAllSilos()
        {
            StopClusterClient();
            StopSecondarySilos();
            if (Primary != null)
            {
                StopPrimarySilo();
            }
            AppDomain.CurrentDomain.UnhandledException -= ReportUnobservedException;
        }

        /// <summary>
        /// Do a semi-graceful Stop of the specified silo.
        /// </summary>
        /// <param name="instance">Silo to be stopped.</param>
        public void StopSilo(SiloHandle2 instance)
        {
            if (instance != null)
            {
                StopOrleansSilo(instance, true);
                if (Primary == instance)
                {
                    Primary = null;
                }
                else
                {
                    additionalSilos.Remove(instance);
                }
            }
        }

        /// <summary>
        /// Do an immediate Kill of the specified silo.
        /// </summary>
        /// <param name="instance">Silo to be killed.</param>
        public void KillSilo(SiloHandle2 instance)
        {
            if (instance != null)
            {
                // do NOT stop, just kill directly, to simulate crash.
                StopOrleansSilo(instance, false);
            }
        }

        /// <summary>
        /// Performs a hard kill on client.  Client will not cleanup resources.
        /// </summary>
        public void KillClient()
        {
            this.InternalClient?.Abort();
            this.InternalClient = null;
        }

        /// <summary>
        /// Do a Stop or Kill of the specified silo, followed by a restart.
        /// </summary>
        /// <param name="instance">Silo to be restarted.</param>
        public SiloHandle2 RestartSilo(SiloHandle2 instance)
        {
            if (instance != null)
            {
                var instanceNumber = instance.InstanceNumber;
                var siloName = instance.Name;
                StopSilo(instance);
                var newInstance = StartOrleansSilo(instanceNumber, this.options);

                if (siloName == Silo.PrimarySiloName)
                {
                    Primary = newInstance;
                }
                else
                {
                    additionalSilos.Add(newInstance);
                }

                return newInstance;
            }

            return null;
        }

        /// <summary>
        /// Restart a previously stopped.
        /// </summary>
        /// <param name="siloName">Silo to be restarted.</param>
        //public SiloHandle2 RestartStoppedSecondarySilo(string siloName)
        //{
        //    if (siloName == null) throw new ArgumentNullException(nameof(siloName));
        //    var newInstance = StartOrleansSilo(Silo.SiloType.Secondary, this.ClusterConfiguration, this.ClusterConfiguration.Overrides[siloName]);
        //    additionalSilos.Add(newInstance);
        //    return newInstance;
        //}

        #region Private methods

        /// <summary>
        /// Initialize the grain client. This should be already done by <see cref="Deploy()"/> or <see cref="DeployAsync"/>
        /// </summary>
        public void InitializeClient()
        {
            WriteLog("Initializing Cluster Client");

            this.InternalClient = (IInternalClusterClient)TestClusterHostFactory.CreateClusterClient("MainClient", this.options.HostConfiguration);
            this.InternalClient.Connect().Wait();
            this.SerializationManager = this.ServiceProvider.GetRequiredService<SerializationManager>();
            this.StreamProviderManager = this.ServiceProvider.GetRequiredService<IRuntimeClient>().CurrentStreamProviderManager;
        }

        private async Task InitializeAsync()
        {
            short silosToStart = this.options.InitialSilosCount;

            if (this.options.UseTestClusterMemebership)
            {
                this.Primary = StartOrleansSilo(this.startedInstances, this.options);
                silosToStart--;
            }

            if (silosToStart > 0)
            {
                await this.StartAdditionalSilos(silosToStart);
            }

            WriteLog("Done initializing cluster");

            if (this.options.InitializeClientOnDeploy)
            {
                InitializeClient();
            }
        }

        private SiloHandle2 StartOrleansSilo(int instanceNumber, TestClusterOptions2 clusterOptions)
        {
            return StartOrleansSilo(this, instanceNumber, clusterOptions);
        }

        /// <summary>
        /// Start a new silo in the target cluster
        /// </summary>
        /// <param name="cluster">The TestCluster2 in which the silo should be deployed</param>
        /// <param name="instanceNumber">The instance number to deploy</param>
        /// <param name="clusterOptions">The options to use.</param>
        /// <returns>A handle to the silo deployed</returns>
        public static SiloHandle2 StartOrleansSilo(TestCluster2 cluster, int instanceNumber, TestClusterOptions2 clusterOptions)
        {
            if (cluster == null) throw new ArgumentNullException(nameof(cluster));

            string siloName = clusterOptions.UseTestClusterMemebership && instanceNumber == 0
                ? Silo.PrimarySiloName
                : $"Secondary_{instanceNumber}";

            var configuration = clusterOptions.HostConfiguration.ToList();
            var hostSpecificConfiguration = new Dictionary<string, string>
            {
                ["SiloPort"] = (clusterOptions.BaseSiloPort + instanceNumber).ToString(),
                ["GatewayPort"] = (clusterOptions.BaseGatewayPort + instanceNumber).ToString(),
                ["SiloName"] = siloName,
            };

            configuration.Add(new MemoryConfigurationSource { InitialData = hostSpecificConfiguration });
            if (clusterOptions.UseTestClusterMemebership)
            {
                hostSpecificConfiguration["PrimarySiloPort"] = clusterOptions.BaseSiloPort.ToString();
                if (instanceNumber == 0)
                {
                }
            }
            var handle = cluster.LoadSiloInNewAppDomain(siloName, configuration);
            Interlocked.Increment(ref cluster.startedInstances);
            return handle;
        }

        private void StopOrleansSilo(SiloHandle2 instance, bool stopGracefully)
        {
            try
            {
                instance.StopSilo(stopGracefully);
                instance.Dispose();
            }
            finally
            {
                Interlocked.Decrement(ref this.startedInstances);
            }
        }

        private SiloHandle2 LoadSiloInNewAppDomain(string siloName, IList<IConfigurationSource> configuration)
        {
            WriteLog("Starting a new silo in app domain {0}", siloName);
            return AppDomainSiloHandle2.Create(siloName, configuration);
        }

        #endregion

        #region Tracing helper functions

        public string GetLog()
        {
            return this.log.ToString();
        }

        private static void ReportUnobservedException(object sender, UnhandledExceptionEventArgs eventArgs)
        {
            Exception exception = (Exception)eventArgs.ExceptionObject;
            // WriteLog("Unobserved exception: {0}", exception);
        }

        private void WriteLog(string format, params object[] args)
        {
            log.AppendFormat(format + Environment.NewLine, args);
        }

        private void FlushLogToConsole()
        {
            Console.WriteLine(GetLog());
        }

        private void WriteLog(object value)
        {
            WriteLog(value.ToString());
        }

        #endregion
    }
}
