using System;
using System.Runtime.ExceptionServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Runtime;
using Orleans.TestingHost;

namespace TestExtensions
{
    public abstract class BaseTestClusterFixture : IDisposable
    {
        private ExceptionDispatchInfo preconditionsException;
        private ILogger appLogger;
        static BaseTestClusterFixture()
        {
            TestDefaultConfiguration.InitializeDefaults();
        }

        protected BaseTestClusterFixture()
        {
            try
            {
                CheckPreconditionsOrThrow();
            }
            catch (Exception ex)
            {
                preconditionsException = ExceptionDispatchInfo.Capture(ex);
                return;
            }

            var testCluster = CreateTestCluster();
            if (testCluster?.Primary == null)
            {
                testCluster?.Deploy();
            }
            this.HostedCluster = testCluster;
            this.appLogger = this.Client?.ServiceProvider.GetRequiredService<ILoggerFactory>().CreateLogger("Application");
        }

        public void EnsurePreconditionsMet()
        {
            preconditionsException?.Throw();
        }

        protected virtual void CheckPreconditionsOrThrow() { }


        protected abstract TestCluster CreateTestCluster();

        public TestCluster HostedCluster { get; }

        public IGrainFactory GrainFactory => this.HostedCluster?.GrainFactory;

        public IClusterClient Client => this.HostedCluster?.Client;

        public ILogger Logger => this.appLogger;
           

        public virtual void Dispose()
        {
            this.HostedCluster?.StopAllSilos();
        }
    }

    public abstract class BaseTestCluster2Fixture : IDisposable
    {
        private ExceptionDispatchInfo preconditionsException;

        static BaseTestCluster2Fixture()
        {
            TestDefaultConfiguration.InitializeDefaults();
        }

        protected BaseTestCluster2Fixture()
        {
            try
            {
                CheckPreconditionsOrThrow();
            }
            catch (Exception ex)
            {
                preconditionsException = ExceptionDispatchInfo.Capture(ex);
                return;
            }

            var testCluster = CreateTestCluster();
            if (testCluster?.Primary == null)
            {
                testCluster?.Deploy();
            }
            this.HostedCluster = testCluster;
        }

        public void EnsurePreconditionsMet()
        {
            preconditionsException?.Throw();
        }

        protected virtual void CheckPreconditionsOrThrow() { }


        protected abstract TestCluster2 CreateTestCluster();

        public TestCluster2 HostedCluster { get; }

        public IGrainFactory GrainFactory => this.HostedCluster?.GrainFactory;

        public IClusterClient Client => this.HostedCluster?.Client;

        public Logger Logger => this.Client?.Logger;

        public virtual void Dispose()
        {
            this.HostedCluster?.StopAllSilos();
        }
    }
}