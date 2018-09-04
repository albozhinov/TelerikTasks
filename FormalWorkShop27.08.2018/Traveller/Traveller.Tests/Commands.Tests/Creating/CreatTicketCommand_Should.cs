using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Commands.Creating;
using Traveller.Core.Database;
using Traveller.Core.Factories;
using Traveller.Models.Abstractions;

namespace Traveller.Tests.Commands.Tests.Creating
{
    [TestClass]
    public class CreatTicketCommand_Should
    {
        [TestMethod]
        public void ThrowsArgumentException_WhenDataIsInvalid()
        {
            // Arrange 
            var dataMock = new Mock<IData>();
            var factoryMock = new Mock<ITravellerFactory>();

            var executeCommand = new CreateTicketCommand(dataMock.Object, factoryMock.Object);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => executeCommand.Execute(new List<string> { "Invalid", "Parameters" }));
        }

        [TestMethod]
        public void ReturnSuccessMessage_WhenDataIsValid()
        {
            // Arrange 
            var dataMock = new Mock<IData>();
            var factoryMock = new Mock<ITravellerFactory>();

            var executeCommand = new CreateTicketCommand(dataMock.Object, factoryMock.Object);
            var validParameters = new List<string> { "0", "30" };

            var journeyMock = new Mock<IJourney>();
            var listOfJourneys = new List<IJourney>() { journeyMock.Object };
            dataMock.Setup(x => x.Journeys).Returns(listOfJourneys);

            var ticketMock = new Mock<ITicket>();
            var listOfTickets = new List<ITicket>() { ticketMock.Object };
            dataMock.Setup(x => x.Tickets).Returns(listOfTickets);

            // Act
            var result = executeCommand.Execute(validParameters);

            //Assert
            StringAssert.Contains(result, "was created.");
        }

        [TestMethod]
        public void CreateTicket_WhenDataIsValid()
        {
            // Arrange 
            var dataMock = new Mock<IData>();
            var factoryMock = new Mock<ITravellerFactory>();

            var executeCommand = new CreateTicketCommand(dataMock.Object, factoryMock.Object);
            var validParameters = new List<string> { "0", "30" };

            var journeyMock = new Mock<IJourney>();
            var listOfJourneys = new List<IJourney>() { journeyMock.Object };
            dataMock.Setup(x => x.Journeys).Returns(listOfJourneys);

            var ticketMock = new Mock<ITicket>();
            var listOfTickets = new List<ITicket>() { ticketMock.Object };
            dataMock.Setup(x => x.Tickets).Returns(listOfTickets);

            factoryMock.Setup(x => x.CreateTicket(journeyMock.Object, 30.00M)).Callback(() => listOfJourneys.Add(journeyMock.Object));

            // Act
            var result = executeCommand.Execute(validParameters);

            //Assert
            factoryMock.Verify(x => x.CreateTicket(journeyMock.Object, 30.00M), Times.Once);
        }

        [TestMethod]
        public void AddedCreateTicket_WhenDataIsValid()
        {
            // Arrange 
            var dataMock = new Mock<IData>();
            var factoryMock = new Mock<ITravellerFactory>();

            var executeCommand = new CreateTicketCommand(dataMock.Object, factoryMock.Object);
            var validParameters = new List<string> { "0", "30" };

            var journeyMock = new Mock<IJourney>();
            var listOfJourneys = new List<IJourney>() { journeyMock.Object };
            dataMock.Setup(x => x.Journeys).Returns(listOfJourneys);

            var ticketMock = new Mock<ITicket>();
            var listOfTickets = new List<ITicket>() { ticketMock.Object };
            dataMock.Setup(x => x.Tickets).Returns(listOfTickets);

            factoryMock.Setup(x => x.CreateTicket(journeyMock.Object, 30.00M)).Callback(() => listOfJourneys.Add(journeyMock.Object));

            // Act
            var result = executeCommand.Execute(validParameters);

            //Assert
            Assert.IsTrue(listOfTickets.Count == 2);
        }
    }
}
