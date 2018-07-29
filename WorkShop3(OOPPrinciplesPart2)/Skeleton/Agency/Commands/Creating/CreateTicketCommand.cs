﻿using Agency.Commands.Contracts;
using Agency.Core.Contracts;
using Agency.Models.Contracts;
using Agency.Models.Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Commands.Creating
{
    // TODO
    class CreateTicketCommand : ICommand
    {
        private readonly IAgencyFactory factory;
        private readonly IEngine engine;

        public CreateTicketCommand(IAgencyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            int ID;
            decimal administrativeCosts;
            IJourney journey;

            try
            {
                ID = int.Parse(parameters[0]);
                administrativeCosts = decimal.Parse(parameters[1]);
                journey = this.engine.Journeys[ID];                
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTicket command parameters.");
            }

            var ticket = this.factory.CreateTicket(journey, administrativeCosts);
            this.engine.Tickets.Add(ticket);

            return $"Ticket with ID {engine.Tickets.Count - 1} was created.";
        }
    }
}
