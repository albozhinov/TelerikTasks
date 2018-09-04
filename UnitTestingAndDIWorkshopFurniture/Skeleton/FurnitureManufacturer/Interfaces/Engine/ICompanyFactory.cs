namespace FurnitureManufacturer.Interfaces.Engine
{
    public interface iCommandFactory
    {
        ICompany CreateCompany(string name, string registrationNumber);
    }
}
