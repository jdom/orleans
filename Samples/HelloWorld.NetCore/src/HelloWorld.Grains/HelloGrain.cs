using System.Numerics;
using HelloWorld.Interfaces;
using System.Threading.Tasks;

namespace HelloWorld.Grains
{
    /// <summary>
    /// Orleans grain implementation class HelloGrain.
    /// </summary>
    public class HelloGrain : Orleans.Grain, IHello
    {
        Task<string> IHello.SayHello(string greeting, Vector3 howFar)
        {
            return Task.FromResult($"You said: '{greeting}', I say: Hello! You are far: {howFar.X}, {howFar.Y}, {howFar.Z}");
        }
    }
}
