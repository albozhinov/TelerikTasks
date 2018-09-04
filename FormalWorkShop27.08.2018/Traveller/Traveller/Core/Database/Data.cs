using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core.Database
{
    public class Data : IData
    {
        public Data()
        {
            this.Vehicles = new List<IVehicle>();
            this.Journeys = new List<IJourney>();
            this.Tickets = new List<ITicket>();
        }

        public List<IVehicle> Vehicles  { get; }

        public List<IJourney> Journeys { get; }

        public List<ITicket> Tickets { get; }
    }
}
