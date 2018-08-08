using OlympicGames.Olympics.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicGames.Olympics.Models
{
    public abstract class Olympian : IOlympian
    {
        // Fields 
        protected string firstName;
        protected string lastName;
        protected string country;

        // Constructor
        public Olympian(string firstName, string lastName, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
        }

        // Properties
        public string FirstName
        {
            get => this.firstName;

            set
            {
                if (value.Length < 2 || 20 < value.Length)
                {
                    throw new ArgumentException("First name must be between 2 and 20 characters long!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;

            set
            {
                if (value.Length < 2 || 20 < value.Length)
                {
                    throw new ArgumentException("Last name must be between 2 and 20 characters long!");
                }
                this.lastName = value;
            }
        }

        public string Country
        {
            get => this.country;
            set
            {
                if (value.Length < 3 || 25 < value.Length)
                {
                    throw new ArgumentException("Country must be between 3 and 25 characters long!");
                }
                this.country = value;
            }
        }
    }
}
