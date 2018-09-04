using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core.Database
{
    public interface IData
    {
         List<IVehicle> Vehicles { get; }

         List<IJourney> Journeys { get; }  

         List<ITicket> Tickets { get; }
    }
}
