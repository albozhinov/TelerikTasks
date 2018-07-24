namespace Cosmetics.Contracts
{
    using System.Collections.Generic;
    
    public interface IToothpaste : IProduct
    {

        IList<string> Ingredients { get; }

    }
}