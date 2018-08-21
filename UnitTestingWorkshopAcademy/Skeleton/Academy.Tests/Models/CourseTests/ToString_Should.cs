using Academy.Models;
using Academy.Models.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Tests.Models.CourseTests
{
    [TestClass]
    public class ToString_Should
    {
        [TestMethod]       
        public void ReturnListOfLectures_WhenTheCollectionIsNotEmpty()
        {            
            // Arrange
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            var lectures = new Mock<ILecture>();
            lectures.Setup(x => x.ToString());
            course.Lectures.Add(lectures.Object);

            // Act
            course.ToString();

            // Assert
            lectures.Verify(x => x.ToString(), Times.Once);
        }

        [TestMethod]
        public void ReturnMessage_WhenListOfLectureIsEmpty()
        {
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            var message = "no lectures"; 
            var result = course.ToString();

            StringAssert.Contains(message, result);            
        }
    }
}
