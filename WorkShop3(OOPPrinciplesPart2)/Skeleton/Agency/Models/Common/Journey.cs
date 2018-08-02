using Agency.Models.Contracts;
using Agency.Models.Vehicles.Contracts;
using System;
using System.Text;

namespace Agency.Models.Common
{
    class Journey : IJourney
    {
        // Fields
        private string destinantion;
        private int disntance;
        private string startLocation;
        private IVehicle vehicle;

        // Constructor
        public Journey(string destination, int distance, string startLocation, IVehicle vehicle)
        {
            this.Destination = destination;
            this.Distance = distance;
            this.StartLocation = startLocation;
            this.Vehicle = vehicle;
        }

        // Properties
        public string Destination
        {
            get => this.destinantion;
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else if (value.Length < 5 || 25 < value.Length)
                {
                    throw new ArgumentException("The Destination's length cannot be less than 5 or more than 25 symbols long.");
                }
                this.destinantion = value;
            }
        } 

        public int Distance
        {
            get => this.disntance;
            protected set
            {
                if (value < 5 || 5000 < value)
                {
                    throw new ArgumentException("The Distance cannot be less than 5 or more than 5000 kilometers.");
                }
                this.disntance = value;
            }
        }
        

        public string StartLocation
        {
            get => this.startLocation;
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else if (value.Length < 5 || 25 < value.Length)
                {
                    throw new ArgumentException("The StartingLocation's length cannot be less than 5 or more than 25 symbols long.");
                }
                this.startLocation = value;
            }
        }

        public IVehicle Vehicle
        {
            get => this.vehicle;
            protected set
            {               
                this.vehicle = value;
            }
        }

        // Methods
        public decimal CalculateTravelCosts()
        {
            return disntance * Vehicle.PricePerKilometer;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Journey ----");
            sb.AppendLine($"Start location: {this.StartLocation}");
            sb.AppendLine($"Destination: {this.Destination}");
            sb.AppendLine($"Distance: {this.Distance}");
            sb.AppendLine($"Vehicle type: {this.Vehicle.Type.ToString()}");
            sb.Append($"Travel costs: {this.CalculateTravelCosts()}");
            return sb.ToString();
        }
    }
}
