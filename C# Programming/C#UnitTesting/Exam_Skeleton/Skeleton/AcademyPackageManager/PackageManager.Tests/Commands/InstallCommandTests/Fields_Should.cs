using Moq;
using NUnit.Framework;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Tests.Commands.InstallCommandTests.Fakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Commands.InstallCommandTests
{
    [TestFixture]
    class Fields_Should
    {
        [Test]
        public void GetInstaller_WhenValueIsValid()
        {
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();

            var installCommand = new InstallCommandFake(installer.Object, package.Object);
            var testInstaller = installCommand.InstallerFake;

            Assert.AreEqual(testInstaller, installCommand.InstallerFake);
        }

        [Test]
        public void GetPackage_WhenValueIsValid()
        {
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();

            var installCommand = new InstallCommandFake(installer.Object, package.Object);
            var testPackage = installCommand.PackageFake;

            Assert.AreEqual(testPackage, installCommand.PackageFake);
        }

        [Test]
        public void ShouldThrowArgumentNullException_WhenInstallerIsNull()
        {
            var package = new Mock<IPackage>();

            Assert.Throws<ArgumentNullException>(() => new InstallCommandFake(null, package.Object));
        }

        [Test]
        public void ShouldThrowArgumentNullException_WhenPackageIsNull()
        {
            var installer = new Mock<IInstaller<IPackage>>();

            Assert.Throws<ArgumentNullException>(() => new InstallCommandFake(installer.Object, null));
        }
    }
}
