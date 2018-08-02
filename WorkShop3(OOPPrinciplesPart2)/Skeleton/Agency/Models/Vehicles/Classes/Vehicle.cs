using System;
using System.Collections.Generic;
using System.Text;
using Agency.Models.Vehicles.Contracts;

namespace Agency.Models.Vehicles.Classes
{
    public abstract class Vehicle : IVehicle
    {
        // Fields
        private int passengerCapacity;
        private VehicleType type;
        private decimal pricePerKilometer;       

        // Constructors
        public Vehicle(int passengerCapacity, VehicleType type, decimal pricePerKilometer)
        {
            this.PassengerCapacity = passengerCapacity;
            this.Type = type;
            this.PricePerKilometer = pricePerKilometer;
        }

        // Properties
        public virtual int PassengerCapacity
        {
            get => this.passengerCapacity;
            set
            {
                if (value < 1 || 800 < value)
                {
                    throw new ArgumentException("A vehicle with less than 1 passengers or more than 800 passengers cannot exist!");
                }
                this.passengerCapacity = value;
            }
        }

        public VehicleType Type
        {
            get => this.type;
            set
            {
                VehicleType parsedType;
                bool isValid = Enum.TryParse(value.ToString(), out parsedType);

                if (!isValid)
                {
                    throw new ArgumentException();
                }
                this.type = parsedType;
            }
        }

        public decimal PricePerKilometer
        {
            get => this.pricePerKilometer;
            protected set
            {
                if (value < (decimal)0.10 || (decimal)2.50 < value)
                {
                    throw new ArgumentException("A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!");
                }
                this.pricePerKilometer = value;
            }
        }
        // Method to override

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\r\nPassenger capacity: {PassengerCapacity}");
            sb.Append($"\r\nPrice per kilometer: {PricePerKilometer}");
            sb.Append($"\r\nVehicle type: {Type.ToString()}");
            return sb.ToString();
        }        
    }
}
