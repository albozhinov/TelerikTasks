using Problem1SchoolCLasses.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPrinciples_Part1
{
    //Students have a name and unique class number    
    public class Student : Person, IComment
    {
        // Fields
        private int uniquenumber;
        private string comment;

        // Constructors
        public Student(string name, int uniquenumber) : base(name)
        {
            this.UniqueNumber = uniquenumber;
        }

        // Properties
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

        public string Comment { get => this.comment; set => this.comment = value; }
    }
}
