using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPrinciples_Part1
{
    //Students have a name and unique class number    
    public class Student : Person
    {
        private int uniquenumber;

        public int UniqueNumber
        {
            get => this.uniquenumber;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.uniquenumber = value;
            }
        }

        public Student(string name, int uniquenumber) : base(name)
        {
            this.UniqueNumber = uniquenumber;
        }
    }
}
