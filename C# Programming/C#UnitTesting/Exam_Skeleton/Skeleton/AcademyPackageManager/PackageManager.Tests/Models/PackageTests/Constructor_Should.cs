using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    class Constructor_Should
    {
        [Test]
        public void SetPassedNameCorrectly()
        {
            var version = new Mock<IVersion>();
            var package = new Package("valid name", version.Object);

            Assert.AreEqual("valid name", package.Name);
        }

        [Test]
        public void SetPassedVersionCorrectly()
        {
            var version = new Mock<IVersion>();
            var package = new Package("valid name", version.Object);

            Assert.AreEqual(version.Object, package.Version);
        }

        [Test]
        public void InstantiateNewPackageRepository_WhenIsNotPasedValue()
        {
            var version = new Mock<IVersion>();
            var package = new Package("valid name", version.Object);

            Assert.IsInstanceOf<ICollection<IPackage>>(package.Dependencies);
        }

        [Test]
        public void SetPassedPackageReposityry_WhenIsPassedValue()
        {
            var dependencies = new Mock<ICollection<IPackage>>();
            var version = new Mock<IVersion>();
            var package = new Package("valid name", version.Object, dependencies.Object);

            Assert.AreEqual(dependencies.Object, package.Dependencies);
        }
    }
}
