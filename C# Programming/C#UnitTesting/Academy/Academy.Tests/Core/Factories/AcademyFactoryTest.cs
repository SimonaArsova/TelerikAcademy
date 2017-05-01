using Academy.Core.Factories;
using Academy.Models.Contracts;
using Academy.Models.Utils.LectureResources;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Core.Factories
{
    [TestFixture]
    class AcademyFactoryTest
    {
        [Test]
        public void CreateLectureResourse_ShouldThrowArgumentException_WhenPassedTypeIsInvalid()
        {
            var academyFactory = AcademyFactory.Instance;

            Assert.Throws<ArgumentException>(() => academyFactory.CreateLectureResource("v", "name", "someURL"));
        }

        [Test]
        public void CreateLectureResourse_ShouldReturnCorrectIntances()
        {
            var academyFactory = AcademyFactory.Instance;

            Assert.IsInstanceOf<VideoResource>(academyFactory.CreateLectureResource("video", "name", "someURL"));
        }

        [Test]
        [TestCase("video")]
        [TestCase("demo")]
        [TestCase("presentation")]
        [TestCase("homework")]
        public void CreateLectureResourse_ShouldReturnCorrectIntancesWithCorrectData(string value)
        {
            var academyFactory = AcademyFactory.Instance;
           
            var mockedResource = new Mock<ILectureResource>();
            mockedResource.Name = "name";
            var actual = academyFactory.CreateLectureResource(value, "name", "someurl");

            Assert.AreEqual(mockedResource.Name, actual.Name);
        }


    }
}
