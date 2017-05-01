
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.Abstractions.UserClassTests
{
    [TestFixture]
    class ConstructorTests
    {
        [Test]
        public void Constructor_ShouldCorrectlyAsignPassedValues()
        {
            var expectedName = "Name";
            var user = new FakeUser(expectedName);

            Assert.AreEqual(expectedName, user.Username);
        }
    }
}
