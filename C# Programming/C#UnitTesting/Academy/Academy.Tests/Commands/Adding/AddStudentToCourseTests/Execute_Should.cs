using Academy.Commands.Adding;
using Academy.Core.Contracts;
using Academy.Models.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Commands.Adding.AddStudentToCourseTests
{
    [TestFixture]
    class Execute_Should
    {
        [Test]
        public void ThrowArgumentException_WhenThePassedCourseFormIsInvalid()
        {
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var courseMock = new Mock<ICourse>();
            var seasonMock = new Mock<ISeason>();

            studentMock.Setup(x => x.Username).Returns("Name");
            engineMock.Setup(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });
            courseMock.Setup(x => x.OnlineStudents).Returns(new List<IStudent>() { studentMock.Object });
            engineMock.Setup(x=>x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });
            seasonMock.Setup(x => x.Courses).Returns(new List<ICourse>() { courseMock.Object });
            var command = new AddStudentToCourseCommand(factoryMock.Object, engineMock.Object);

            Assert.Throws<ArgumentException>(() => command.Execute(new List<string>() { "Name", "0", "0", "Invalid form" }));
        }

        [Test]
        public void CorrectlyAddTheFoundStudentIntoTheCourse_WhenThePassedCourseFormIsalid()
        {
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var courseMock = new Mock<ICourse>();
            var seasonMock = new Mock<ISeason>();
            var anotherStudentMock = new Mock<IStudent>();

            studentMock.Setup(x => x.Username).Returns("Name");
            anotherStudentMock.Setup(x => x.Username).Returns("Another name");
            engineMock.Setup(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });
            courseMock.Setup(x => x.OnlineStudents).Returns(new List<IStudent>() { anotherStudentMock.Object });
            engineMock.Setup(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });
            seasonMock.Setup(x => x.Courses).Returns(new List<ICourse>() { courseMock.Object });
            var command = new AddStudentToCourseCommand(factoryMock.Object, engineMock.Object);

            command.Execute(new List<string>() { "Name", "0", "0", "online" });

            Assert.AreEqual(2, courseMock.Object.OnlineStudents.Count);
        }

        [Test]
        public void ReturnSuccessMessage_WhenDataIsAddedToCollection()
        {
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var courseMock = new Mock<ICourse>();
            var seasonMock = new Mock<ISeason>();
            var anotherStudentMock = new Mock<IStudent>();

            studentMock.Setup(x => x.Username).Returns("Name");
            anotherStudentMock.Setup(x => x.Username).Returns("Another name");
            engineMock.Setup(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });
            courseMock.Setup(x => x.OnlineStudents).Returns(new List<IStudent>() { anotherStudentMock.Object });
            engineMock.Setup(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });
            seasonMock.Setup(x => x.Courses).Returns(new List<ICourse>() { courseMock.Object });
            var command = new AddStudentToCourseCommand(factoryMock.Object, engineMock.Object);

            var result = command.Execute(new List<string>() { "Name", "0", "0", "online" });

            StringAssert.Contains("Name", result);
            StringAssert.Contains("0", result);
        }
    }
}
