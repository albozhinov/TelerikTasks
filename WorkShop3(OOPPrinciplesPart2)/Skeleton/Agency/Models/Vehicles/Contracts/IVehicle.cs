namespace Agency.Models.Vehicles.Contracts
{
    public interface IVehicle
    {
        int PassengerCapacity { get; }

        VehicleType Type { get; }

        decimal PricePerKilometer { get; }

        string ToString();        
    }
}