using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;

namespace OlympicGames.Core.Commands
{
    public class ListOlympiansCommand : Command, ICommand
    {
        private string key = "firstname";
        private string order = "asc";

        public ListOlympiansCommand(IList<string> commandParameters)
            : base(commandParameters)
        {         
          
            if (commandParameters.Count == 1)
            {
                this.key = commandParameters[0];                
            }
            else if (commandParameters.Count == 2)
            {
                this.key = commandParameters[0];
                this.order = commandParameters[1];
            }
        }

        // Properties 
        public string Key
        {
            get => this.key;
            private set {this.key = value; }
        }

        public string Order
        {
            get => this.order;
            private set {this.order = value; }
        }

        // Use it! It works! I promise, I tested it!
        public override string Execute()
        {
            var stringBuilder = new StringBuilder();
            var sorted = this.Committee.Olympians.ToList();        

            if (sorted.Count == 0)
            {
                stringBuilder.AppendLine(string.Format("NO OLYMPIANS ADDED"));
            }
            else
            {
                stringBuilder.AppendLine(string.Format("Sorted by [key: {0}] in [order: {1}]", this.key, this.order));
            }           

            if (this.order.ToLower().Trim() == "desc")
            {
                sorted = this.Committee.Olympians.OrderByDescending(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }
            else
            {
                sorted = this.Committee.Olympians.OrderBy(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }
            
            foreach (var item in sorted)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
