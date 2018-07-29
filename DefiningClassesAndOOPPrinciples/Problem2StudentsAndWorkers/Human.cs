using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2StudentsAndWorkers
{
    public abstract class Human
    {
        // Fields
        private string firstName;
        private string lastName;

        // Constructors
        public Human(string firstName, string lastName)
        {
            this.Firstname = firstName;
            this.Lastname = lastName;
        }

        // Properties
        public string Firstname
        {
            get => this.firstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.firstName = value;
            }
        }

        public string Lastname
        {
            get => this.lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.lastName = value;
            }
        }
    }
}
