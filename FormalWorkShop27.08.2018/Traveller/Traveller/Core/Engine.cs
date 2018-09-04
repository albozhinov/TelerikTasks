using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Commands.Contracts;
using Traveller.Core.Database;
using Traveller.Core.Providers;
using Traveller.Models;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core
{
    public class Engine : IEngine
    {
        private const string TerminationCommand = "Exit";
        private const string NullProvidersExceptionMessage = "cannot be null.";        

        private IData data;
        private ICommandFactory commandFactory;
        private ICommandParser commandParser;
         
        
        private StringBuilder Builder = new StringBuilder();

        public Engine(IData data, ICommandFactory commandFactory, ICommandParser parser)
        {
            this.data = data;
            this.commandFactory = commandFactory;
            this.commandParser = parser;
        }             

        public void Start()
        {
            while (true)
            {
                try
                {
                    var commandAsString = Console.ReadLine();

                    if (commandAsString.ToLower() == TerminationCommand.ToLower())
                    {
                        Console.Write(this.Builder.ToString());
                        break;
                    }

                    this.Builder.AppendLine(this.commandParser.ProcessCommand(commandAsString));
                }
                catch (Exception ex)
                {
                    this.Builder.AppendLine(ex.Message);                    
                }
            }
        }        
    }
}
