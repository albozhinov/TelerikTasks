using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Database;
using Traveller.Core.Factories;

namespace Traveller.Commands.Creating
{
    public class CreateTrainCommand : ICommand
    {
        private IData data;
        private ITravellerFactory factory;

        public CreateTrainCommand(IData data, ITravellerFactory factory)
        {
            this.data = data;
            this.factory = factory;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            int cartsCount;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                cartsCount = int.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTrain command parameters.");
            }

            var train = this.factory.CreateTrain(passengerCapacity, pricePerKilometer, cartsCount);
            data.Vehicles.Add(train);

            return $"Vehicle with ID {data.Vehicles.Count - 1} was created.";
        }
    }
}
