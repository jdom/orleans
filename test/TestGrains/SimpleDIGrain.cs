using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Orleans;
using UnitTests.GrainInterfaces;
using Orleans.Runtime;
using Microsoft.Extensions.DependencyInjection;

namespace UnitTests.Grains
{
    public class DIGrainWithInjectedServices : Grain, IDIGrainWithInjectedServices
    {
        private readonly IInjectedService injectedService;
        private readonly IInjectedScopedService injectedScopedService;
        private readonly IGrainFactory injectedGrainFactory;
        private readonly long grainFactoryId;
        public static readonly ObjectIDGenerator ObjectIdGenerator = new ObjectIDGenerator();

        public DIGrainWithInjectedServices(IInjectedService injectedService, IInjectedScopedService injectedScopedService,  IGrainFactory injectedGrainFactory)
        {
            this.injectedService = injectedService;
            this.injectedGrainFactory = injectedGrainFactory;
            this.injectedScopedService = injectedScopedService;
            bool set;
            // get the object Id for injected GrainFactory, 
            // object Id will be the same if the underlying object is the same,
            // this is one way to prove that this GrainFactory is injected from DI
            this.grainFactoryId = ObjectIdGenerator.GetId(this.injectedGrainFactory, out set);
        }

        public Task<long> GetTicksFromService()
        {
            return injectedService.GetTicks();
        }

        public Task<string> GetInjectedSingletonServiceValue()
        {
            return Task.FromResult(this.injectedService.GetInstanceValue());
        }

        public Task<string> GetInjectedScopedServiceValue()
        {
            return Task.FromResult(this.injectedScopedService.GetInstanceValue());
        }

        public Task<long> GetGrainFactoryId()
        {
            return Task.FromResult(this.grainFactoryId);
        }

        public Task DoDeactivate()
        {
            this.DeactivateOnIdle();
            return Task.CompletedTask;
        }

        public Task AssertCanResolveSameServiceInstances()
        {
            if (!ReferenceEquals(this.ServiceProvider.GetRequiredService<IInjectedService>(), this.injectedService)) throw new Exception("singleton not equal");
            if (!ReferenceEquals(this.ServiceProvider.GetRequiredService<IInjectedScopedService>(), this.injectedScopedService)) throw new Exception("scoped not equal");

            return Task.CompletedTask;
        }
    }

    public class ExplicitlyRegisteredSimpleDIGrain : Grain, ISimpleDIGrain
    {
        private readonly IInjectedService injectedService;
        private string someValueThatIsNotRegistered;

        public ExplicitlyRegisteredSimpleDIGrain(IInjectedService injectedService, string someValueThatIsNotRegistered)
        {
            this.injectedService = injectedService;
            this.someValueThatIsNotRegistered = someValueThatIsNotRegistered;
        }

        public Task<long> GetTicksFromService()
        {
            return injectedService.GetTicks();
        }
    }

    public interface IInjectedService
    {
        Task<long> GetTicks();
        string GetInstanceValue();
    }

    public class InjectedService : IInjectedService, IDisposable
    {
        private readonly string instanceValue = Guid.NewGuid().ToString();
        private readonly Logger logger;

        public Task<long> GetTicks()
        {
            return Task.FromResult(DateTime.UtcNow.Ticks);
        }
        public string GetInstanceValue() => this.instanceValue;

        public InjectedService(Factory<string, Logger> loggerFactory)
        {
            this.logger = loggerFactory("InjectedService");
        }

        public void Dispose()
        {
            logger.Info($"Disposed instance {this.instanceValue}");
        }

    }

    public interface IInjectedScopedService
    {
        string GetInstanceValue();
    }

    public class InjectedScopedService : IInjectedScopedService, IDisposable
    {
        private readonly string instanceValue = Guid.NewGuid().ToString();
        private readonly Logger logger;

        public InjectedScopedService(Factory<string, Logger> loggerFactory)
        {
            this.logger = loggerFactory("InjectedScopedService");
        }

        public void Dispose()
        {
            logger.Info($"Disposed instance {this.instanceValue}");
        }

        public string GetInstanceValue() =>  this.instanceValue;
    }
}
