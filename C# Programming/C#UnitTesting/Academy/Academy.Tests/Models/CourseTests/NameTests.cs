using Academy.Models;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.CourseTests
{
    [TestFixture]
    class NameTests
    {
        [Test]
        public void Name_ShouldThrowArgumentException_WhenPassedvalueIsInvalid()
        {
            var course = new Course("Name", 2, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));

            Assert.Throws<ArgumentException>(() => course.Name = "");
        }

        [Test]
        public void Name_ShouldNotThrowArgumentException_WhenPassedvalueIsValid()
        {
            var course = new Course("Name", 2, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));

            Assert.DoesNotThrow(() => course.Name = "Name");
        }

        [Test]
        public void Name_ShoulCorrectlyAssign_WhenPassedvalueIsValid()
        {
            var expectedName = "Name";
            var course = new Course(expectedName, 2, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));

            Assert.AreEqual(expectedName, course.Name);
        }
    }
}
