using Moq;
using NUnit.Framework;
using PackageManager.Info.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Tests.Repositories.PackageRepositoryTests.Fakes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Repositories.PackageRepositoryTests
{
    [TestFixture]
    class Add_Should
    {
        [Test]
        public void SetCorrectPackageValue()
        {
            var package = new Mock<IPackage>();
            var logger = new Mock<ILogger>();
            var packages = new List<IPackage>() { package.Object };

            var packageRepository = new PackageRepositoryFake(logger.Object, packages);
            packageRepository.Add(package.Object);

            Assert.AreEqual(packages, packageRepository.PackagesFake);
        }

        [Test]
        public void ThrowArgumentNullException_WhenLoggerValueIsNull()
        {
            var package = new Mock<IPackage>();
            var logger = new Mock<ILogger>();
            var packages = new List<IPackage>() { package.Object };

            var packageRepository = new PackageRepositoryFake(logger.Object, packages);

            Assert.Throws<ArgumentNullException>(() => new PackageRepositoryFake(null, packages));
        }

        [Test]
        public void SetCorrectLoggerValue_WhenValueIsNotNull()
        {
            var package = new Mock<IPackage>();
            var logger = new Mock<ILogger>();
            var packages = new List<IPackage>() { package.Object };

            var packageRepository = new PackageRepositoryFake(logger.Object, packages);
            packageRepository.Add(package.Object);

            Assert.AreEqual(logger.Object, packageRepository.LoggerFake);
        }

        [Test]
        public void InstantiatePackage_IfPackageDoesntExist()
        {
            var packages = new Mock<ICollection<IPackage>>();
            var logger = new Mock<ILogger>();

            var packageRepository = new PackageRepositoryFake(logger.Object, null);

            Assert.IsInstanceOf<ICollection<IPackage>>(packageRepository.PackagesFake);
        }

        //[Test]
        //public void TestIfThePackageAlreadyExistsWithTheSameVersion()
        //{
        //    var package = new Mock<IPackage>();
        //    var anotherPackage = new Mock<IPackage>();
        //    var logger = new Mock<ILogger>();
        //    var packages = new List<IPackage>() { package.Object };
        //    var version = new Mock<IVersion>();
        //    version.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

        //    var packageRepository = new PackageRepositoryFake(logger.Object, packages);

        //    package.Setup(x => x.Version).Returns(version.Object);
        //    anotherPackage.Setup(x => x.Version).Returns(version.Object);

        //    var outputStream = new StringWriter();
        //    var defaultStream = Console.Out;
        //    Console.SetOut(outputStream);
            
        //    packages.Add(package.Object);
        //    packageRepository.Add(anotherPackage.Object);

        //    Assert.AreEqual("same version", outputStream.ToString());
        //    Console.SetOut(defaultStream);
        //}
    }
}
