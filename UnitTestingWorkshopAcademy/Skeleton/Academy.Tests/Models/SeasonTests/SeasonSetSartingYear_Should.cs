using Academy.Models;
using Academy.Models.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Tests.Models.SeasonTests
{
    [TestClass]
    public class SeasonSetSartingYear_Should
    {
        [DataTestMethod]
        [DataRow(2015)]
        [DataRow(2018)]
        public void ThrowArgumentException_WhenInvalidValueIsPassed(int startingYear)
        {
            // Arange 
            var season = new Season(2017, 2017, Initiative.CoderDojo);

            // Act & Asserte
            Assert.ThrowsException<ArgumentException>(() => season.StartingYear = startingYear);
        }
    }
}
