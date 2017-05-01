using NUnit.Framework;
using PackageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
    class Properties_Should
    {
        [Test]
        public void SetPassedNameCorrectly_WhenValidNameIsPassed()
        {
            var project = new Project("valid name", "valid location");

            Assert.AreEqual("valid name", project.Name);
        }

        [Test]
        public void SetPassedLocationCorrectly_WhenValidNameIsPassed()
        {
            var project = new Project("valid name", "valid location");

            Assert.AreEqual("valid location", project.Location);
        }
    }
}
