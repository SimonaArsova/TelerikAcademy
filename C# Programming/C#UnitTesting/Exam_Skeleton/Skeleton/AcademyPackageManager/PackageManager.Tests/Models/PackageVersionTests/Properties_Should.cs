using NUnit.Framework;
using PackageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageVersionTests
{
    [TestFixture]
    class Properties_Should
    {
        [Test]
        public void GetProperty_ShouldReturnCorrectValue_WhenPassedMajorValueIsValid()
        {
            var packageVersion = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);

            var major = packageVersion.Major;

            Assert.AreEqual(1, major);
        }

        [Test]
        public void GetProperty_ShouldReturnCorrectValue_WhenPassedMinorValueIsValid()
        {
            var packageVersion = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);

            var minor = packageVersion.Minor;

            Assert.AreEqual(2, minor);
        }

        [Test]
        public void GetProperty_ShouldReturnCorrectValue_WhenPassedPatchValueIsValid()
        {
            var packageVersion = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);

            var patch = packageVersion.Patch;

            Assert.AreEqual(3, patch);
        }

        [Test]
        public void GetProperty_ShouldReturnCorrectValue_WhenPassedVersionTypeValueIsValid()
        {
            var packageVersion = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);

            var version = packageVersion.VersionType;

            Assert.AreEqual(Enums.VersionType.alpha, version);
        }

        [Test]
        public void Property_ShouldThrowArgumentException_WhenPassedMajorValueIsInValid()
        {
            Assert.Throws<ArgumentException>(() => new PackageVersion(-1, 2, 3, Enums.VersionType.alpha));
        }

        [Test]
        public void Property_ShouldThrowArgumentException_WhenPassedMinorValueIsInValid()
        {
            Assert.Throws<ArgumentException>(() => new PackageVersion(1, -2, 3, Enums.VersionType.alpha));
        }

        [Test]
        public void Property_ShouldThrowArgumentException_WhenPassedPatchValueIsInValid()
        {
            Assert.Throws<ArgumentException>(() => new PackageVersion(1, 2, -3, Enums.VersionType.alpha));
        }

        [Test]
        public void Property_ShouldThrowArgumentException_WhenPassedVersionTypeValueIsInValid()
        {
            Enums.VersionType s = new Enums.VersionType();
            Assert.Throws<ArgumentException>(() => new PackageVersion(1, -2, 3, s));
        }
    }
}
