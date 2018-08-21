using System.Collections.Generic;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;
using System.Linq;
using System;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : Command, ICommand 
    {
        // Constructor
        public CreateSprinterCommand(IList<string> commandLine)
            : base(commandLine)
        {
            
        }

        public override string Execute()
        {            
            string firstName;
            string lastName;
            string country;            
            Dictionary<string, double> records = new Dictionary<string, double>();

            try
            {
                firstName = this.CommandParameters[0];
                lastName = this.CommandParameters[1];
                country = this.CommandParameters[2];
                
                foreach (var item in this.CommandParameters.Skip(3).ToList())
                {
                    var splitedItem = item.Split('/');
                    string discipline = splitedItem[0];
                    double time = double.Parse(splitedItem[1]);
                    records.Add(discipline, time);
                }                             
            }           
            catch (Exception)
            {
                if (this.CommandParameters.Count < 3)
                {
                    throw new ArgumentException("Parameters count is not valid!");
                }

                throw new ArgumentException("Failed to create Sprinter command parameters.");
            }

            var sprinter = this.Factory.CreateSprinter(firstName, lastName, country, records);
            this.Committee.Olympians.Add(sprinter);           
            
            return $"Created Sprinter{sprinter.ToString()}";
        }
    }
}
