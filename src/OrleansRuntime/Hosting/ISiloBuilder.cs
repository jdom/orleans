namespace Orleans.Hosting
{
    public interface ISiloBuilder
    {
        ISiloHostBuilder HostBuilder { get; }
    }

    internal class SiloBuilder : ISiloBuilder
    {
        public SiloBuilder(ISiloHostBuilder hostBuilder)
        {
            this.HostBuilder = hostBuilder;
        }

        public ISiloHostBuilder HostBuilder { get; }
    }
}
