using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPrinciples_Part1
{
    public class Person
    {
        protected string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
