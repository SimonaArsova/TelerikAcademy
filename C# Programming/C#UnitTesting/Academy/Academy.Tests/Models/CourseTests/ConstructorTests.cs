using Academy.Models;
using Academy.Models.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.CourseTests
{
    [TestFixture]
    class ConstructorTests
    {
        [Test]
        public void Constructor_ShouldCorrectlyAssignPassedValues()
        {
            string expName = "Name";
            int expLectures = 5;
            DateTime expStartDate = new DateTime(2010,10,10);
            DateTime expEndDate = new DateTime(2011, 11, 11);

            var course = new Course(expName, expLectures, expStartDate, expEndDate);

            Assert.AreEqual(expName, course.Name);
            Assert.AreEqual(expLectures, course.LecturesPerWeek);
            Assert.AreEqual(expStartDate, course.StartingDate);
            Assert.AreEqual(expEndDate, course.EndingDate);
        }

        [Test]
        public void Constructor_ShouldCorrectlyInitializeLecturesCollection()
        {
            var course = new Course("name", 2, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));

            Assert.IsInstanceOf(typeof(List<ILecture>),course.Lectures);
        }

        [Test]
        public void Constructor_ShouldCorrectlyInitializeOnlineStudentsCollection()
        {
            var course = new Course("name", 2, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));

            Assert.IsInstanceOf(typeof(List<IStudent>), course.OnlineStudents);
        }

        [Test]
        public void Constructor_ShouldCorrectlyInitializeOnsiteStudentsCollection()
        {
            var course = new Course("name", 2, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));

            Assert.IsInstanceOf(typeof(List<IStudent>), course.OnsiteStudents);
        }
    }
}
