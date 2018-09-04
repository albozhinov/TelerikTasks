using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Database;

namespace Traveller.Commands.Creating
{
    public class ListVehiclesCommand : ICommand
    {
        private IData data;

        public ListVehiclesCommand(IData data)
        {
            this.data = data;
        }

        public string Execute(IList<string> parameters)
        {
            var vehicles = data.Vehicles;

            if (vehicles.Count == 0)
            {
                return "There are no registered vehicles.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, vehicles);
        }
    }
}
