using Domain.Configuration;
using Infrastructure.Configuration;
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
            });
        }
    }
}
