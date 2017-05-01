using Moq;
using NUnit.Framework;
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
    class Execute_Should
    {
        [Test]
        public void TestForCallingThePerformOperationFromTheInstaller()
        {
            var installer = new Mock<IInstaller<IPackage>>();
            var package = new Mock<IPackage>();

            var installCommand = new InstallCommandFake(installer.Object, package.Object);

            installer.Setup(x => x.Operation).Returns(InstallerOperation.Install);

            installer.Verify();
        }
    }
}
