using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Database;
using Traveller.Core.Factories;
using Traveller.Models;
using Traveller.Models.Abstractions;

namespace Traveller.Commands.Creating
{
    public class CreateTicketCommand : ICommand
    {
        private IData data;
        private ITravellerFactory factory;

        public CreateTicketCommand(IData data, ITravellerFactory factory)
        {
            this.data = data;
            this.factory = factory;
        }

        public string Execute(IList<string> parameters)
        {
            IJourney journey;
            decimal administrativeCosts;

            try
            {
                journey = data.Journeys[int.Parse(parameters[0])];
                administrativeCosts = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTicket command parameters.");
            }

            var ticket = this.factory.CreateTicket(journey, administrativeCosts);
            data.Tickets.Add(ticket);

            return $"Ticket with ID {data.Tickets.Count - 1} was created.";
        }
    }
}
