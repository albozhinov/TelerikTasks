using Microsoft.VisualStudio.TestTools.UnitTesting;
using Academy.Models;
using Academy.Models.Enums;

namespace Academy.Tests.Models.SeasonTests
{
    [TestClass]
    public class SeasonConstructor_Should
    {
        [TestMethod]
        public void SetProperStartingDate_WhenObjectIsConstructed()
        {
            // Arrange & Act
            var season = new Season(2017, 2017, Initiative.SoftwareAcademy);
            var result = season.StartingYear;

            // Assert
            Assert.AreEqual(2017, result);
        }

        [TestMethod]
        public void SetProperEndingDate_WhenObjectIsConstructed()
        {
            // Arrange & Act
            var season = new Season(2017, 2017, Initiative.SoftwareAcademy);
            var result = season.EndingYear;

            // Assert
            Assert.AreEqual(2017, result);
        }
        [TestMethod]
        public void InitilizeStudentCollection_WhenObjectIsConstructed()
        {
            //int starting, int ending, Initiative initiative

            // Arrange
            var season = new Season(2017, 2017, Initiative.SoftwareAcademy);

            // Assert
            Assert.IsNotNull(season.Students);
        }

        [TestMethod]
        public void InitilizeTrainersCollection_WhenObjectIsConstructed()
        {
            // Arrange
            var season = new Season(2017, 2017, Initiative.SoftwareAcademy);

            // Assert
            Assert.IsNotNull(season.Trainers);
        }

        [TestMethod]
        public void InitilizeCoursesCollection_WhenObjectIsConstructed()
        {
            // Arrange
            var season = new Season(2017, 2017, Initiative.SoftwareAcademy);

            // Assert
            Assert.IsNotNull(season.Courses);
        }
    }
}
