namespace Orleans.Hosting
{
    public interface ISiloBuilder
    {
        IHostBuilder HostBuilder { get; }
    }

    internal class SiloBuilder : ISiloBuilder
    {
        public SiloBuilder(IHostBuilder hostBuilder)
        {
            this.HostBuilder = hostBuilder;
        }

        public IHostBuilder HostBuilder { get; }
    }
}
