using Academy.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Tests.Models.CourseTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void SetProperName_WhenTheObjectIsConstructed()
        {
            // Arrange & Act
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Assert
            Assert.AreEqual("Telerik Alpha .NET", course.Name);
        }

        [TestMethod]
        public void SetProperLecturePerWeek_WhenTheObjectIsConstructed()
        {
            // Arrange & Act
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Assert
            Assert.AreEqual(5, course.LecturesPerWeek);
        }

        [TestMethod]
        public void SetProperStartinDate_WhenTheObjectIsConstructed()
        {
            // Arrange
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Act
            var startingDate = course.StartingDate;

            // Assert
            Assert.AreEqual(startingDate, course.StartingDate);
        }

        [TestMethod]
        public void SetProperEndingDate_WhenTheObjectIsConstructed()
        {
            // Arrange
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Act
            var endingDate = course.EndingDate;

            // Assert
            Assert.AreEqual(endingDate, course.EndingDate);
        }

        [TestMethod]
        public void InitilizeLectureCollection_WhenTheObjectIsConstructed()
        {
            // Arrange & Act
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Assert
            Assert.IsNotNull(course.Lectures);
        }

        [TestMethod]
        public void InitilizeOnlineStudentsCollection_WhenTheObjectIsConstructed()
        {
            // Arrange & Act
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Assert
            Assert.IsNotNull(course.OnlineStudents);
        }

        [TestMethod]
        public void InitilizeOnsiteStudentsCollection_WhenTheObjectIsConstructed()
        {
            // Arrange & Act
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Assert
            Assert.IsNotNull(course.OnsiteStudents);
        }
    }
}
