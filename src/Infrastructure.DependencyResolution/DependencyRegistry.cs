using Domain.Configuration;
using Domain.Logging;
using Infrastructure.Configuration;
using Infrastructure.Logging;
using StructureMap;

namespace Infrastructure.DependencyResolution
{
    internal class DependencyRegistry
    {
        public readonly Container Container;

        public DependencyRegistry()
        {
            Container = new Container(_ =>
            {
                _.For<IConfigurationAdapter>().Singleton().Use<ConfigurationAdapter>();
                _.For<ILogger>().Singleton().Use<NLogLogger>();
            });
        }
    }
}
