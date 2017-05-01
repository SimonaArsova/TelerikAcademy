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
    class Properties_Should
    {
        [Test]
        public void SetPassedNameCorrectly_WhenPassedNameIsValid()
        {
            var version = new Mock<IVersion>();
            var package = new Package("valid name", version.Object);

            Assert.AreEqual("valid name", package.Name);
        }

        [Test]
        public void SetPassedVersionCorrectly_WhenPassedVersionIsValid()
        {
            var version = new Mock<IVersion>();
            var package = new Package("valid name", version.Object);

            Assert.AreEqual(version.Object, package.Version);
        }

        [Test]
        public void SetPassedURLCorrectly_WhenPassedURLIsValid_MajorTest()
        {
            var version = new Mock<IVersion>();
            var package = new Package("valid name", version.Object);

            StringAssert.Contains(version.Object.Major.ToString(), package.Url);
        }

        [Test]
        public void SetPassedURLCorrectly_WhenPassedURLIsValid_MinorTest()
        {
            var version = new Mock<IVersion>();
            var package = new Package("valid name", version.Object);

            StringAssert.Contains(version.Object.Minor.ToString(), package.Url);
        }

        [Test]
        public void SetPassedURLCorrectly_WhenPassedURLIsValid_PatchTest()
        {
            var version = new Mock<IVersion>();
            var package = new Package("valid name", version.Object);

            StringAssert.Contains(version.Object.Patch.ToString(), package.Url);
        }

        [Test]
        public void SetPassedURLCorrectly_WhenPassedURLIsValid_VersionTypeTest()
        {
            var version = new Mock<IVersion>();
            var package = new Package("valid name", version.Object);

            StringAssert.Contains(version.Object.VersionType.ToString(), package.Url);
        }

    }
}
