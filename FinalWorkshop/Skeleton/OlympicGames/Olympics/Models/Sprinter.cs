using OlympicGames.Olympics.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicGames.Olympics.Models
{
    public class Sprinter : Olympian, ISprinter
    {
        // Field
        private IDictionary<string, double> personalRecords;

        // Constructors        
        public Sprinter(string firstName, string lastName, string country,
                        IDictionary<string, double> personalRecords)
            : base(firstName, lastName, country)
        {
            if (personalRecords.Count == 0)
            {
                
            }
            this.personalRecords = personalRecords;
        }

        // Property
        public IDictionary<string, double> PersonalRecords
        {
            get => new Dictionary<string, double>(this.personalRecords);

            set
            {               
                this.personalRecords = value;
            }
        }

        // Method
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\r\nSPRINTER: {this.FirstName} {this.LastName} from {this.Country}");
            if (this.PersonalRecords.Count == 0)
            {
                sb.Append($"\r\nNO PERSONAL RECORDS SET");
            }
            else
            {
                sb.Append($"\r\nPERSONAL RECORDS:");
                foreach (var item in this.PersonalRecords)
                {
                    sb.Append($"\r\n{item.Key}m: {item.Value}s");
                }
            }            
            return sb.ToString();
        }

    }
}
