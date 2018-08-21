using Academy.Tests.Abstractions.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Tests.Abstractions.UserTests
{
    [TestClass]
    public class SetUsername_Should
    {
        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("i")]
        [DataRow("moooreeee than sixtheeennn letterrsss")]
        public void ThrowArgumentException_WhenInvalidValueIsPassed(string name)
        {
            // Arrange
            var user = new UserMock("Pesho");
            
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => user.Username = name);
        }
    }
}
