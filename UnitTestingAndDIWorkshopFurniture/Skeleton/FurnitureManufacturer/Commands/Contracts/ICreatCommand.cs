using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureManufacturer.Commands.Contracts
{
    public interface ICreatCommand
    {
        string Execute(IList<string> parameters);
    }
}
