using Academy.Models;
using Academy.Models.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.CourseTests
{
    [TestFixture]
    class ToStringTests
    {
        [Test]
        public void ToString_ShouldReturnPassedDataAListOfLectures()
        {
            var course = new Course("Name", 2, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));

            var mockLecture = new Mock<ILecture>();
            var anotherMockLecture = new Mock<ILecture>();

            course.Lectures.Add(mockLecture.Object);
            course.Lectures.Add(anotherMockLecture.Object);

            Assert.That(course.ToString().Contains(mockLecture.ToString()));
            Assert.That(course.ToString().Contains(anotherMockLecture.ToString()));
        }

        [Test]
        public void ToString_ShouldReturnRightCountOfLectures()
        {
            var course = new Course("Name", 2, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));

            var mockLecture = new Mock<ILecture>();
            mockLecture.Setup(x => x.ToString());

            course.Lectures.Add(mockLecture.Object);
            course.ToString();

            mockLecture.Verify(x=>x.ToString(), Times.Once);
        }

        [Test]
        public void ToString_ShouldReturnMessageIfThereAreNoLectures()
        {
            var course = new Course("Name", 2, new DateTime(2010, 10, 10), new DateTime(2011, 11, 11));


            StringAssert.Contains("There are no lectures in this course", course.ToString());
        }
    }
}
