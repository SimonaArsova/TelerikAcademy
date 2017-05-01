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
    class Equals_Should
    {
        [Test]
        public void ThrowArgumentException_WhenOtherIsNull()
        {
            var versionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();
            var package = new Package("valid name", versionMock.Object);
            var result = package.Equals(packageMock.Object);

            Assert.Throws<ArgumentException>(() => package.Equals(new Object()));
        }

        [Test]
        public void ThrowArgumentException_WhenTheObjectIsNotIPackage()
        {
            var versionMock = new Mock<IVersion>();
            var obj = new Object();
            var package = new Package("valid name", versionMock.Object);

            Assert.Throws<ArgumentException>(() => package.Equals(obj));
        }

        [Test]
        public void TestIfThePassedPackageIsEqualToThePackage()
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

        [Test]
        public void TestIfThePassedPackageIsNotEqualToThePackage()
        {
            var versionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();
            packageMock.Setup(x => x.Name).Returns("valid name");
            packageMock.Setup(x => x.Version.Major).Returns(1);
            packageMock.Setup(x => x.Version.Minor).Returns(1);
            packageMock.Setup(x => x.Version.Patch).Returns(0);
            packageMock.Setup(x => x.Version.VersionType).Returns(Enums.VersionType.alpha);

            var package = new Package("valid name", versionMock.Object);

            Assert.AreEqual(-1, package.CompareTo(packageMock.Object));
        }
    }
}
