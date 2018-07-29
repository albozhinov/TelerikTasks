using Agency.Models.Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agency.Models.Vehicles.Classes
{
    public class Airplane : Vehicle, IAirplane
    {
        // Field
        private bool hasFreeFood;

        // Constructor
        public Airplane(int passangerCapacity, VehicleType type, decimal pricePerKilometer, bool hasFreeFood)
            : base(passangerCapacity, type, pricePerKilometer)
        {
            this.HasFreeFood = hasFreeFood;
        }

        // Propertie
        public bool HasFreeFood
        {
            get => this.hasFreeFood;
            set => this.hasFreeFood = value;
        }

        // Method
        public override string ToString()
        {
            return $"Airplane ----\r\nPassenger capacity: {this.PassengerCapacity}\r\nPrice per kilometer: {this.PricePerKilometer}\r\nVehicle type: {this.Type.ToString()}\r\nHas free food: {this.HasFreeFood}";
        }
    }
}
