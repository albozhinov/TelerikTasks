using Academy.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Tests.Models.CourseTests
{
    [TestClass]
    public class SetName_Should
    {
        [DataTestMethod]
        [DataRow ("i")]
        [DataRow ("very very very very very very very very very very very very long string")]
        public void ThrowArgumentException_WhenInvalidValueIsPassed(string name)
        {
            // Arange
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => course.Name = name);
        }
    }
}
