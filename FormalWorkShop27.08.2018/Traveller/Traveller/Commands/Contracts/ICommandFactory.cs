using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.Commands.Contracts
{
    public interface ICommandFactory
    {
        ICommand GetCommand(string commandName);
    }
}
