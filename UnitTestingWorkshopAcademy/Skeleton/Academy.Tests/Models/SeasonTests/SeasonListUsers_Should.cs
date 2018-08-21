using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Academy.Tests.Models.SeasonTests
{
    [TestClass]
    public class SeasonListUsers_Should
    {
        [TestMethod]
        public void ReturnListOfStudents_WhenTheCollectionIsNotEmpty()
        {
            // Arrange
            var season = new Season(2017, 2017, Initiative.SoftwareAcademy);

            var studentMock = new Mock<IStudent>();
            studentMock.Setup(x => x.ToString());
            season.Students.Add(studentMock.Object);

            // Act
            season.ListUsers();

            // Assert           
            studentMock.Verify(x => x.ToString(), Times.Once);
        }

        [TestMethod]
        public void ReturnListOfTrainers_WhenTheCollectionIsNotEmpty()
        {
            // Arrange
            var season = new Season(2017, 2017, Initiative.SoftwareAcademy);

            var trainerMock = new Mock<ITrainer>();
            trainerMock.Setup(x => x.ToString());
            season.Trainers.Add(trainerMock.Object);

            // Act
            season.ListUsers();

            // Assert            
            trainerMock.Verify(x => x.ToString(), Times.Once);
        }

        [TestMethod]
        public void ReturnAMessage_WhenCollectionIsEmpty()
        {
            // Arrange
            var season = new Season(2017, 2017, Initiative.SoftwareAcademy);

            // Act            
            var message = "There are no users in this season!";
            var result = season.ListUsers();

            // Assert               
            StringAssert.Contains(message, result);
        }
    }
}
