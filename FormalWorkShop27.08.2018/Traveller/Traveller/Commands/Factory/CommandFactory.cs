using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Commands.Contracts;
using Autofac;

namespace Traveller.Commands.Factory
{
    public class CommandFactory : ICommandFactory
    {
        private IComponentContext context;

        public CommandFactory(IComponentContext context)
        {
            this.context = context;
        }

        public ICommand GetCommand(string commandName)
        {
            return this.context.ResolveNamed<ICommand>(commandName);
        }
    }
}
