using Academy.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Tests.Models.CourseTests
{
    [TestClass]
    public class GetStartingDate_Should
    {
        [TestMethod]
        public void ReturnTheProperValue_WhenGetMethodIsCalled()
        {
            // Arrange
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act
            var result = course.StartingDate;

            // Assert
            Assert.AreEqual(course.StartingDate, result);
        }
    }
}
