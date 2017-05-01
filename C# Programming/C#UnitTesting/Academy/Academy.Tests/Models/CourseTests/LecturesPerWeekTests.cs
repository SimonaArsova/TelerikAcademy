using Academy.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.CourseTests
{
    [TestFixture]
    class LecturesPerWeekTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(8)]

        public void Lectures_ShouldThrowArgumentException_WhenPassedValueIsInvalid(int value)
        {
            var course = new Course("Name", 2, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));

            Assert.Throws<ArgumentException>(() => course.LecturesPerWeek=value);
        }

        [Test]
        public void Lectures_ShouldThrowArgumentException_WhenPassedValueIsInvalid()
        {
            var course = new Course("Name", 2, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));

            Assert.DoesNotThrow(() => course.LecturesPerWeek = 3);
        }

        [Test]
        public void Lectures_ShouldCorrectlyAssign_WhenPassedvalueIsValid()
        {
            var expectedLecturesPerWeek = 2;
            var course = new Course("Name", expectedLecturesPerWeek, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));

            Assert.AreEqual(expectedLecturesPerWeek, course.LecturesPerWeek);
        }
    }
}
