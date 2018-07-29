namespace Agency.Models.Vehicles.Contracts
{
    public interface ITrain : IVehicle
    {
        int PassengerCapacity { get; }
        //decimal PricePerKilometer { get; }
        /// Please, please, please implement me
        //VehicleType Type { get; set; }
        int Carts { get; }
    }
}