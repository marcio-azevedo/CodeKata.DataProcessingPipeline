using Domain.Configuration;
using Domain.Logging;
using NUnit.Framework;

namespace Infrastructure.DependencyResolution.IntegrationTests
{
    [TestFixture]
    public class BaseFactoryTests
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            //var _mocker = new AutoMoqer();
        }

        [Test]
        public void BaseFactory_GetInstance_Succeeds()
        {
            // Arrange

            // Act
            var instance = BaseFactory.Instance;

            // Assert
            Assert.IsNotNull(instance);
        }

        [Test]
        public void BaseFactory_ResolveIConfigurationAdapter_Succeeds()
        {
            // Arrange

            // Act
            var instance = BaseFactory.Instance.Resolve<IConfigurationAdapter>();

            // Assert
            Assert.IsNotNull(instance);
            Assert.AreEqual(BaseFactory.Instance.Container.GetInstance<IConfigurationAdapter>(), instance);
        }

        [Test]
        public void BaseFactory_ResolveILogger_Succeeds()
        {
            // Arrange

            // Act
            var instance = BaseFactory.Instance.Resolve<ILogger>();

            // Assert
            Assert.IsNotNull(instance);
            Assert.AreEqual(BaseFactory.Instance.Container.GetInstance<ILogger>(), instance);
        }
    }
}
