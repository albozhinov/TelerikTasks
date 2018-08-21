using Academy.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Tests.Models.CourseTests
{
    [TestClass]
    public class SetStartingDate_Should
    {
        [DataTestMethod]
        [DataRow(null)]        
        public void ThrowArgumentException_WhenInvalidValueIsPassed(DateTime? startingDate)
        {
            // Arange
            var course = new Course("Telerik Alpha .NET", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Act & Asserte
            Assert.ThrowsException<ArgumentNullException>(() => course.StartingDate = startingDate);
        }
    }
}
