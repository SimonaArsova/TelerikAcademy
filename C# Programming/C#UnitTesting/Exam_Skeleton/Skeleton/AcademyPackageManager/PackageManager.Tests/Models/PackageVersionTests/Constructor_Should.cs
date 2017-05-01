using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageVersionTests
{
    [TestFixture]
    class Constructor_Should
    {
        [Test]
        public void SetPassedMajor()
        {
            var packageVersion = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);

            Assert.AreEqual(1, packageVersion.Major);
        }

        [Test]
        public void SetPassedMinor()
        {
            var packageVersion = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);

            Assert.AreEqual(2, packageVersion.Minor);
        }

        [Test]
        public void SetPassedPatch()
        {
            var packageVersion = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);

            Assert.AreEqual(3, packageVersion.Patch);
        }

        [Test]
        public void SetPassedVersionType()
        {
            var packageVersion = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);

            Assert.AreEqual(Enums.VersionType.alpha, packageVersion.VersionType);
        }

    }
}
