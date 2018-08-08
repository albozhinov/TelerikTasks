using System;
using System.Collections.Generic;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;
using System.Linq;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : Command, ICommand
    {
        public CreateBoxerCommand(IList<string> commandLine) 
            : base(commandLine)
        {
        }

        public override string Execute()
        {
            string firstName;
            string lastName;
            string country;
            string category;            
            int wins;            
            int losses;

            try
            {                
                firstName = this.CommandParameters[0];
                lastName = this.CommandParameters[1];
                country = this.CommandParameters[2];
                category = this.CommandParameters[3].First().ToString().ToUpper() + this.CommandParameters[3].Substring(1);
                wins = int.Parse(this.CommandParameters[4]);
                losses = int.Parse(this.CommandParameters[5]);
            }
            catch(FormatException)
            {
                throw new ArgumentException("Wins and losses must be numbers!");
            }
            catch
            {
                if (this.CommandParameters.Count < 6)
                {
                    throw new ArgumentException("Parameters count is not valid!");
                }
                
                throw new ArgumentException("Failed to CreateBoxer command parameters.");
            }

            var boxer = this.Factory.CreateBoxer(firstName, lastName, country, category, wins, losses);
            this.Committee.Olympians.Add(boxer);

            return $"Created Boxer{boxer.ToString()}";
        }        
    }
}
