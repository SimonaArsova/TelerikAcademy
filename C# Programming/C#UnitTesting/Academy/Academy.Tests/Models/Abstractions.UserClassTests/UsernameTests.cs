using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.Abstractions.UserClassTests
{
    [TestFixture]
    class UsernameTests
    {
        [Test]
        public void Username_ShouldThrowArgumentException_WhenPassedValueIsInvalid()
        {
            var user = new FakeUser("Name");

            Assert.Throws<ArgumentException>(()=>user.Username = "ab");
        }

        [Test]
        public void Username_ShouldNotThrowArgumentException_WhenPassedValueIsValid()
        {
            var user = new FakeUser("Name");

            Assert.DoesNotThrow(() => user.Username = "abcd");
        }

        [Test]
        public void Username_ShouldCorrectlyAssignPassedValue()
        {
            var expectedName = "Name";
            var user = new FakeUser("AnotherName");
            user.Username = expectedName;

            Assert.AreEqual(expectedName, user.Username);
        }
    }
}
