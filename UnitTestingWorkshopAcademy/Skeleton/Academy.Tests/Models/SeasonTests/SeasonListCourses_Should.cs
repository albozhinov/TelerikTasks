using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Academy.Tests.Models.SeasonTests
{
    [TestClass]
    public class SeasonListCourses_Should
    {
        [TestMethod]
        public void ReturnListOfCourses_WhenTheCollectionIsNotEmpty()
        {
            // Arrange
            var season = new Season(2017, 2017, Initiative.SoftwareAcademy);

            var courseMock = new Mock<ICourse>();
            courseMock.Setup(x => x.ToString());
            season.Courses.Add(courseMock.Object);

            // Act
            season.ListCourses();

            // Assert
            courseMock.Verify(x => x.ToString(), Times.Once);
        }

        [TestMethod]
        public void ReturnMessage_WhenListOfCoursesIsEmpty()
        {
            // Arrange
            var season = new Season(2017, 2017, Initiative.SoftwareAcademy);

            // Act           
            var message = "There are no courses in this season!";
            var result = season.ListCourses();

            // Assert
            StringAssert.Contains(message, result);
        }
    }
}
