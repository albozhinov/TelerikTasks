using Agency.Models.Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agency.Models.Vehicles.Classes
{
    class Bus : Vehicle, IBus
    {
        // Fields
        private int passengerCapacity;

        // Constructor
        public Bus(int passangerCapacity, VehicleType type, decimal pricePerKilometer)
            : base(passangerCapacity, type, pricePerKilometer)
        {

        }

        // Properties
        public override int PassengerCapacity
        {
            get => this.passengerCapacity;
            set
            {
                if (value < 10 || 50 < value)
                {
                    throw new ArgumentException("A bus cannot have less than 10 passengers or more than 50 passengers.");
                }
                this.passengerCapacity = value;
            }
        }

        // Method
        public override string ToString()
        {
            return $"Bus ----\r\nPassenger capacity: {this.PassengerCapacity}\r\nPrice per kilometer: {this.PricePerKilometer}\r\nVehicle type: {this.Type.ToString()}";
        }
    }
}
