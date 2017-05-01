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
    class CompareTo_Should
    {
        [Test]
        public void ThrowArgumentException_WhenOtherIsInvalid()
        {
            var versionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();
            var package = new Package("valid name", versionMock.Object);

            Assert.Throws<ArgumentException>(() => package.CompareTo(packageMock.Object));
        }

        [Test]
        public void ThrowArgumentException_WhenThePackageIsNotWithTheSameName()
        {
            var versionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();
            packageMock.Setup(x => x.Name).Returns("another valid name");
            var package = new Package("valid name", versionMock.Object);

            Assert.Throws<ArgumentException>(() => package.CompareTo(packageMock.Object));
        }

        [Test]
        public void TestIfThePassedPackageIsLowerVersion()
        {
            var versionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();
            packageMock.Setup(x => x.Name).Returns("valid name");
            packageMock.Setup(x => x.Version.Major).Returns(1);
            packageMock.Setup(x => x.Version.Minor).Returns(1);
            packageMock.Setup(x => x.Version.Patch).Returns(1);
            packageMock.Setup(x => x.Version.VersionType).Returns(Enums.VersionType.alpha);

            var package = new Package("valid name", versionMock.Object);

            Assert.AreEqual(-1, package.CompareTo(packageMock.Object));
        }

        [Test]
        public void TestIfThePassedPackageIsHigherVersion()
        {
            var versionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();
            packageMock.Setup(x => x.Name).Returns("valid name");
            packageMock.Setup(x => x.Version.Major).Returns(-1);
            packageMock.Setup(x => x.Version.Minor).Returns(-1);
            packageMock.Setup(x => x.Version.Patch).Returns(-1);
            packageMock.Setup(x => x.Version.VersionType).Returns(Enums.VersionType.alpha);

            var package = new Package("valid name", versionMock.Object);

            Assert.AreEqual(1, package.CompareTo(packageMock.Object));
        }

        [Test]
        public void TestIfThePassedPackageIsSameVersion()
        {
            var versionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();
            packageMock.Setup(x => x.Name).Returns("valid name");
            packageMock.Setup(x => x.Version.Major).Returns(0);
            packageMock.Setup(x => x.Version.Minor).Returns(0);
            packageMock.Setup(x => x.Version.Patch).Returns(0);
            packageMock.Setup(x => x.Version.VersionType).Returns(Enums.VersionType.alpha);

            var package = new Package("valid name", versionMock.Object);

            Assert.AreEqual(0, package.CompareTo(packageMock.Object));
        }
    }
}
