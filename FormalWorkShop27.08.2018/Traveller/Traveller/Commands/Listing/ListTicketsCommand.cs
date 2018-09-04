using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Database;

namespace Traveller.Commands.Creating
{
    public class ListTicketsCommand : ICommand
    {
        private IData data;

        public ListTicketsCommand(IData data)
        {
            this.data = data;
        }

        public string Execute(IList<string> parameters)
        {
            var tickets = data.Tickets;

            if (tickets.Count == 0)
            {
                return "There are no registered tickets.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, tickets);
        }
    }
}
