using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Database;
using Traveller.Core.Factories;

namespace Traveller.Commands.Creating
{
    public class CreateBusCommand : ICommand
    {
        private IData data;
        private ITravellerFactory factory;

        public CreateBusCommand(IData data, ITravellerFactory factory)
        {
            this.data = data;
            this.factory = factory;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateBus command parameters.");
            }

            var bus = this.factory.CreateBus(passengerCapacity, pricePerKilometer);
            data.Vehicles.Add(bus);

            return $"Vehicle with ID {data.Vehicles.Count - 1} was created.";
        }
    }
}
