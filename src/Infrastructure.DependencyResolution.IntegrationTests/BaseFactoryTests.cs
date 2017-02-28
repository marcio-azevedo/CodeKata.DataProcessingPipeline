﻿using Infrastructure.Configuration;
using NUnit.Framework;

namespace Infrastructure.DependencyResolution.IntegrationTests
{
    [TestFixture]
    public class BaseFactoryTests
    {
        [SetUp]
        public void SetUp()
        {
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
    }
}
