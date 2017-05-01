using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Moq;
using NUnit.Framework;

namespace Academy.Tests.Models.SeasonTests
{
    [TestFixture]
    class ListUserTests
    {
        [Test]
        public void ListUsers_ShouldReturnAListOfStudentsAndTrainers()
        {
            var season = new Season(2016, 2016, Initiative.SoftwareAcademy);

            var mockedStudent = new Mock<IStudent>();
            var mockedТrainer = new Mock<ITrainer>();

            season.Students.Add(mockedStudent.Object);
            season.Trainers.Add(mockedТrainer.Object);

            season.ListUsers();

            mockedТrainer.Verify();
            mockedStudent.Verify();
        }

        [Test]
        public void ListUsers_ShouldReturnAMessageIfListIsEmpty()
        {
            var season = new Season(2016, 2016, Initiative.SoftwareAcademy);

            StringAssert.Contains("no users", season.ListUsers());
        }
    }
}
