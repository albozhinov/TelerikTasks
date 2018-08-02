using Agency.Models.Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agency.Models.Vehicles.Classes
{
    class Bus : Vehicle, IBus
    {
        // Constructor
        public Bus(int passangerCapacity, VehicleType type, decimal pricePerKilometer)
            : base(passangerCapacity, type, pricePerKilometer)
        {

        }

        // Properties
        public override int PassengerCapacity
        {
            get => base.PassengerCapacity;
            set
            {
                if (value < 10 || 50 < value)
                {
                    throw new ArgumentException("A bus cannot have less than 10 passengers or more than 50 passengers.");
                }
                base.PassengerCapacity = value;
            }
        }

        // Method
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Bus ----");
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}
