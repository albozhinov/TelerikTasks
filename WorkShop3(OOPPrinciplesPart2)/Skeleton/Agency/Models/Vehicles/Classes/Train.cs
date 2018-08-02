using System;
using System.Collections.Generic;
using System.Text;
using Agency.Models.Vehicles.Contracts;

namespace Agency.Models.Vehicles.Classes
{
    public class Train : Vehicle, ITrain
    {
        // Field
        private int carts;       

        // Constructors
        public Train(int passangerCpacity, VehicleType type, decimal pricePerKilometer, int carts)
            : base(passangerCpacity, type, pricePerKilometer)
        {
            this.Carts = carts;
        }

        // Properties
        public int Carts
        {
            get => this.carts;
            private set
            {
                if (value < 1 || 15 < value)
                {
                    throw new ArgumentException("A train cannot have less than 1 cart or more than 15 carts.");
                }
                this.carts = value;
            }
        }
        public override int PassengerCapacity
        {
            get => base.PassengerCapacity;
            set
            {
                if (value < 30 || 150 < value)
                {
                    throw new ArgumentException("A train cannot have less than 30 passengers or more than 150 passengers.");
                }
                base.PassengerCapacity = value;
            }
        }

        // Method
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Train ----");
            sb.Append(base.ToString());
            sb.Append($"\r\nCarts amount: {this.Carts}");
            return sb.ToString();
        }
    }
}
