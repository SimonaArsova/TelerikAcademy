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

namespace Academy.Tests.Commands.Adding.AddStudentToSeason
{
    [TestFixture]
    class ExecuteTests
    {
        [Test]
        public void Execute_ShouldThrowArgumentException_WhenThePassedStudentIsAlreadyAPartOfTheSeason()
        {
                       
            var factoryMock = new Mock<IAcademyFactory>();
            var studentMock = new Mock<IStudent>();
            var engineMock = new Mock<IEngine>();
            var seasonMock = new Mock<ISeason>();

            var command = new AddStudentToSeasonCommand(factoryMock.Object, engineMock.Object);

            studentMock.Setup(x => x.Username).Returns("Pesho");
            engineMock.Setup(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });
            seasonMock.Setup(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });
            engineMock.Setup(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });

            Assert.Throws<ArgumentException>(() => command.Execute(new List<string>() { "Pesho", "0" }));
        }

        [Test]
        public void Execute_ShouldCorrectlyAddTheFoundStudentIntoTheSeason()
        {

            var factoryMock = new Mock<IAcademyFactory>();
            var studentMock = new Mock<IStudent>();
            var anotherStudentMock = new Mock<IStudent>();
            var engineMock = new Mock<IEngine>();
            var seasonMock = new Mock<ISeason>();

            var command = new AddStudentToSeasonCommand(factoryMock.Object, engineMock.Object);

            studentMock.Setup(x => x.Username).Returns("Pesho");
            engineMock.Setup(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });

            anotherStudentMock.Setup(x => x.Username).Returns("Gosho");

            seasonMock.Setup(x => x.Students).Returns(new List<IStudent>() { anotherStudentMock.Object });
            engineMock.Setup(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });

            var message = command.Execute(new List<string>() { "Pesho", "0" });

            Assert.AreEqual(2, seasonMock.Object.Students.Count); 
        }

        [Test]
        public void Execute_ShouldCorrectlyReturnMessage()
        {

            var factoryMock = new Mock<IAcademyFactory>();
            var studentMock = new Mock<IStudent>();
            var anotherStudentMock = new Mock<IStudent>();
            var engineMock = new Mock<IEngine>();
            var seasonMock = new Mock<ISeason>();

            var command = new AddStudentToSeasonCommand(factoryMock.Object, engineMock.Object);

            studentMock.Setup(x => x.Username).Returns("Pesho");
            engineMock.Setup(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });

            anotherStudentMock.Setup(x => x.Username).Returns("Gosho");

            seasonMock.Setup(x => x.Students).Returns(new List<IStudent>() { anotherStudentMock.Object });
            engineMock.Setup(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });

            var message = command.Execute(new List<string>() { "Pesho", "0" });

            StringAssert.Contains("Pesho", message);
            StringAssert.Contains("0", message);
        }
    }
}
