using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2StudentsAndWorkers
{
    public class Student : Human
    {
        // Fields
        private int grade;

        // Constructors
        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        // Properties
        public int Grade
        {
            get => this.grade;
            set => this.grade = value;           
        }

    }
}
