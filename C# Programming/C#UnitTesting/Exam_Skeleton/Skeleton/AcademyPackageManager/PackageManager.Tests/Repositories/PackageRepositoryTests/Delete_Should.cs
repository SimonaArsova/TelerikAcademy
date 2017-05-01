using Moq;
using NUnit.Framework;
using PackageManager.Info.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Tests.Repositories.PackageRepositoryTests.Fakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Repositories.PackageRepositoryTests
{
    [TestFixture]
    class Delete_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenPassedNullPackage()
        {
            var package = new Mock<IPackage>();
            var logger = new Mock<ILogger>();
            var packages = new List<IPackage>() { package.Object };

            var packageRepository = new PackageRepositoryFake(logger.Object, packages);

            Assert.Throws<ArgumentNullException>(() => packageRepository.Delete(package.Object), null);
        }

        [Test]
        public void TestValidPackage()
        {
            var package = new Mock<IPackage>();
            package.Setup(x => x.Name).Returns("name");
            var logger = new Mock<ILogger>();
            var packages = new List<IPackage>() { package.Object };

            var packageRepository = new PackageRepositoryFake(logger.Object, packages);

            Assert.Throws<ArgumentNullException>(() => packageRepository.Delete(package.Object), "not exist");
        }

        //[Test]
        //public void PackageFound_ButDependencyCannotBeRemoved()
        //{
        //    var package = new Mock<IPackage>();
        //    var logger = new Mock<ILogger>();
        //    var packages = new List<IPackage>() { package.Object };

        //    package.Setup(x => x.Name).Returns("name");
        //    packages.Add(package.Object);
        //    package.Setup(x => x.Dependencies).Returns(packages);

        //    var packageRepository = new PackageRepositoryFake(logger.Object, packages);

        //    packageRepository.Delete(package.Object);

        //    package.Verify();
        //}

    }
}
