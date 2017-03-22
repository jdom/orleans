using System.Threading.Tasks;
using Orleans;

namespace UnitTests.GrainInterfaces
{
    public interface ISimpleDIGrain : IGrainWithIntegerKey
    {
        Task<long> GetTicksFromService();
    }

    public interface IDIGrainWithInjectedServices : ISimpleDIGrain
    {
        Task<long> GetGrainFactoryId();
        Task<string> GetInjectedSingletonServiceValue();
        Task<string> GetInjectedScopedServiceValue();
        Task AssertCanResolveSameServiceInstances();
        Task DoDeactivate();
    }
}
