using System;
using Infrastructure.Configuration;
using StructureMap;

namespace Infrastructure.DependencyResolution
{
    // http://csharpindepth.com/Articles/General/Singleton.aspx
    public sealed class BaseFactory : IBaseFactory
    {
        private static readonly Lazy<BaseFactory> Lazy =
            new Lazy<BaseFactory>(() => new BaseFactory());

        internal readonly DependencyRegistry DependencyRegistry;

        public Container Container => DependencyRegistry.Container;

        public static BaseFactory Instance => Lazy.Value;

        private BaseFactory()
        {
            DependencyRegistry = new DependencyRegistry();
        }
        
        public T Resolve<T>()
        {
            return DependencyRegistry.Container.GetInstance<T>();
        }
    }

    public class ConfigurationFactory
    {
        public static IConfigurationAdapter GetConfigurationAdapter()
        {
            return BaseFactory.Instance.Resolve<IConfigurationAdapter>();
        }
    }
}
