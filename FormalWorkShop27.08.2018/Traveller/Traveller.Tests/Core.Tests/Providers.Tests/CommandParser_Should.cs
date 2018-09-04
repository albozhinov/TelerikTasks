using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Moq;
using Traveller.Core.Providers;

namespace Traveller.Tests.Core.Tests.Providers.Tests
{
    [TestClass]
    public class CommandParser_Should
    {
        [DataTestMethod]
        [DataRow(null)]
        [DataRow(" ")]
        public void ThrowsArgumentException_WhenDataIsInvalid(string commandAsString)
        {
            // Arrange
            var contextMock = new Mock<IComponentContext>();

            var parser = new CommandParser(contextMock.Object);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => parser.ProcessCommand(commandAsString));
        }
    }
}
