namespace Cosmetics.Contracts
{
    using Cosmetics.Common;
    // Each Shampoo has name, brand, price, gender, milliliters, usage
    public interface IShampoo : IProduct
    {       
        uint Milliliters { get; }
        UsageType Usage { get; }
    }
}