using Problem1SchoolCLasses.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPrinciples_Part1
{
    //In the school there are classes of students.
    class School : IComment
    {
        // Fields
        private string name;
        private List<Class> classes;
        private string comment;

        // Constructors
        public School()
        {
            this.classes = new List<Class>();
        }

        public School(string name)
            : this()
        {
            this.Name = name;
        }

        // Properties
        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }

        public List<Class> Classes { get => new List<Class>(this.classes); }        

        public string Comment { get => this.comment; set => this.comment = value; }

       // Methods
       public void AddClass(Class newClass)
        {
            this.classes.Add(newClass);
        }
    }
}
