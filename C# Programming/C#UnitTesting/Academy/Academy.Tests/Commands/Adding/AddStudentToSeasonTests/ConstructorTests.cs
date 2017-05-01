using Academy.Commands.Adding;
using Academy.Core.Contracts;
using Academy.Tests.Commands.Adding.AddStudentToSeason.Fakes;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Commands.Adding
{
    [TestFixture]
    class ConstructorTests
    {
        [Test]
        public void Constructor_ShouldYThrowAgrumentNullExceptionWhenAPassedFactoryIsNull()
        {
            var mockedEngine = new Mock<IEngine>();

            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(null, mockedEngine.Object));
        }

        [Test]
        public void Constructor_ShouldYThrowAgrumentNullExceptionWhenAPassedEngineIsNull()
        {
            var mockedFactory = new Mock<IAcademyFactory>();

            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(mockedFactory.Object,null));
        }

        [Test]
        public void Constructor_ShouldCorrectlyAssignFactory_WhenPassedValuesAreValid()
        {
            var mockedFactory = new Mock<IAcademyFactory>();
            var mockedEngine = new Mock<IEngine>();

            var addStudentToSeasonCommand = new AddStudentToSeasonFake(mockedFactory.Object, mockedEngine.Object);

            Assert.AreSame(mockedFactory.Object, addStudentToSeasonCommand.AcademyFactory);
        }

        [Test]
        public void Constructor_ShouldCorrectlyAssignEngine_WhenPassedValuesAreValid()
        {
            var mockedFactory = new Mock<IAcademyFactory>();
            var mockedEngine = new Mock<IEngine>();

            var addStudentToSeasonCommand = new AddStudentToSeasonFake(mockedFactory.Object, mockedEngine.Object);

            Assert.AreSame(mockedEngine.Object, addStudentToSeasonCommand.Engine);
        }

    }
}
