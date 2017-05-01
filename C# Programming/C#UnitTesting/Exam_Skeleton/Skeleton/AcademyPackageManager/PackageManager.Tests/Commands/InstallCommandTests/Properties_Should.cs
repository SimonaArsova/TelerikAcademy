using Moq;
using NUnit.Framework;
using PackageManager.Core.Contracts;
using PackageManager.Enums;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Commands.InstallCommandTests.Fakes
{
    [TestFixture]
    class Properties_Should
    {
        [Test]
        public void SetCorrectlyDefaultInstallerOperation()
        {
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();

            var installCommand = new InstallCommandFake(installer.Object, package.Object);

            Assert.AreEqual(InstallerOperation.Install, installCommand.InstallerFake.Operation);
        }

    }
}
