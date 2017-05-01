using Moq;
using NUnit.Framework;
using PackageManager.Commands;
using PackageManager.Core.Contracts;
using PackageManager.Enums;
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
    class Constructor_Should
    {
        [Test]
        public void SetCorrectlyInstaller_WhenValueIsValid()
        {
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();

            var installCommand = new InstallCommandFake(installer.Object, package.Object);

            Assert.AreEqual(installer.Object, installCommand.InstallerFake);
        }

        [Test]
        public void SetCorrectlyPackage_WhenValueIsValid()
        {
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();

            var installCommand = new InstallCommandFake(installer.Object, package.Object);

            Assert.AreEqual(package.Object, installCommand.PackageFake);
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

            Assert.Throws < ArgumentNullException>(() => new InstallCommandFake(installer.Object, null));
        }

        [Test]
        public void SetCorrectlyInstallerOperation()
        {
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();

            var installCommand = new InstallCommandFake(installer.Object, package.Object);

            Assert.AreEqual(InstallerOperation.Install, installCommand.InstallerFake.Operation);
        }
    }
}
