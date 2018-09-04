using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureManufacturer.Commands
{
    public interface ICommandFactory
    {
        ICreatCommand GetCommand(string commandName);
    }
}
