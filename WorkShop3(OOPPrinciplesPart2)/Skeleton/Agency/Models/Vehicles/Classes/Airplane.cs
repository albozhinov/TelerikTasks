using Agency.Models.Vehicles.Contracts;
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
            StringBuilder sb = new StringBuilder();
            sb.Append("Airplane ----");
            sb.Append(base.ToString());
            sb.Append($"\r\nHas free food: {this.HasFreeFood}");
            return sb.ToString();
        }
    }
}
