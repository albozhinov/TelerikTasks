using Agency.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agency.Models.Common
{
    class Ticket : ITicket
    {
        // Fields
        private decimal administrativeCosts;
        private IJourney journey;
        
        // Constructor
        public Ticket(decimal administrativeCosts, IJourney journey)
        {
            this.AdministrativeCosts = administrativeCosts;
            this.Journey = journey;
        }
            
        // Properties
        public decimal AdministrativeCosts
        {
            get => this.administrativeCosts;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.administrativeCosts = value;
            }
        }

        public IJourney Journey
        {
            get => this.journey;
            set => this.journey = value;
        }

        // Methods
        public decimal CalculatePrice()
        {
            return this.AdministrativeCosts + Journey.CalculateTravelCosts();
        }

        public override string ToString()
        {
            return $"Ticket ----\r\nDestination: {this.Journey.Destination}\r\nPrice: {this.CalculatePrice()}";
        }
    }
}
