using Academy.Tests.Abstractions.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Tests.Abstractions.UserTests
{
    [TestClass]
    public class GetUserName_Should
    {
        [TestMethod]
        public void ReturnProperUsername_WhenTheGetMethodIsCalled()
        {
            // Arrange
            var user = new UserMock("Pesho");

            // Act
            var result = user.Username;
            // Assert
            Assert.AreEqual("Pesho", result);
        }
    }
}
