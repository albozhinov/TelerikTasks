using Agency.Commands.Contracts;
using Agency.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Commands.Creating
{
    // TODO
    class CreateAirplaneCommand : ICommand
    {
        private readonly IAgencyFactory factory;
        private readonly IEngine engine;

        public CreateAirplaneCommand(IAgencyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            bool hasfreefood;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                hasfreefood = bool.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateAirplane command parameters.");
            }

            var ariplane = this.factory.CreatAirplane(passengerCapacity, pricePerKilometer, hasfreefood);
            this.engine.Vehicles.Add(ariplane);

            return $"Vehicle with ID {engine.Vehicles.Count - 1} was created.";
        }
    }
}
