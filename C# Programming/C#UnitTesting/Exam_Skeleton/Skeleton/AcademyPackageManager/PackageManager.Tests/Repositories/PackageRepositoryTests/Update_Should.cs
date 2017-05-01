using Moq;
using NUnit.Framework;
using PackageManager.Info.Contracts;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Repositories.PackageRepositoryTests.Fakes
{
    [TestFixture]
    class Update_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenPassedNullPackage()
        {
            var package = new Mock<IPackage>();
            var logger = new Mock<ILogger>();
            var packages = new List<IPackage>() { package.Object };

            var packageRepository = new PackageRepositoryFake(logger.Object, null);

            Assert.Throws<ArgumentNullException>(() => packageRepository.Update(package.Object));
        }

        //[Test]
        //public void TestValidPackage()
        //{
        //    var package = new Mock<IPackage>();
        //    var logger = new Mock<ILogger>();
        //    var packages = new List<IPackage>() { package.Object };
        //    var anotherPackage = new Mock<IPackage>();

        //    var packageRepository = new PackageRepositoryFake(logger.Object, packages);

        //    Assert.Throws<ArgumentNullException>(() => packageRepository.Update(anotherPackage.Object));
        //}
    }
}
