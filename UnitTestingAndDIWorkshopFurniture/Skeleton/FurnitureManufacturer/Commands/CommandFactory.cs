using System;
using System.Collections.Generic;
using System.Text;
using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Interfaces.Engine;
using Autofac;

namespace FurnitureManufacturer.Commands
{
    public class CommandFactory : ICommandFactory
    {
        IComponentContext autofacContext;

        public CommandFactory(IComponentContext autofacContext)
        {
            this.autofacContext = autofacContext;
        }


        public ICreatCommand GetCommand(string commandName)
        {
            return this.autofacContext.ResolveNamed<ICreatCommand>(commandName);
        }
    }
}
