using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
    class Constructor_Should
    {
        [Test]
        public void SetPassedNameCorrectly()
        {
            var project = new Project("valid name", "valid location");

            Assert.AreEqual("valid name", project.Name);
        }

        [Test]
        public void SetPassedLocationCorrectly()
        {
            var project = new Project("valid name", "valid location");

            Assert.AreEqual("valid location", project.Location);
        }

        [Test]
        public void InstantiateNewPackageRepository_WhenIsNotPasedValue()
        {
            var project = new Project("valid name", "valid location");

            Assert.IsInstanceOf<IRepository<IPackage>>(project.PackageRepository);
        }

        [Test]
        public void SetPassedPackageReposityry_WhenIsPassedValue()
        {
            var packages = new Mock<IRepository<IPackage>>();
            var project = new Project("valid name", "valid location", packages.Object );

            Assert.AreEqual(packages.Object, project.PackageRepository);
        }
    }
}
