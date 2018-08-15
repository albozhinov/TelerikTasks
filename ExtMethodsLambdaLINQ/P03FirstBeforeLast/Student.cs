using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P03FirstBeforeLast
{
    public class Student
    {
        private string firstName;
        private string lastName;
        // Problem 4
        private int age;
        // Problem 7
        private string fn;
        private string telNumber;
        private string email;
        private List<int> marks;
        private int groupNumber;


        public Student(string fname, string lname, int age)
        {
            this.marks = new List<int>();
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
        }

        public Student(string fname, string lname, int age, string fnumber, string telephoneNum,
                       string email, List<int> marks, int groupNumber)
            : this(fname, lname, age)
        {
            this.FN = fnumber;
            this.TelNumber = telephoneNum;
            this.Email = email;
            this.Marks.AddRange(marks);
            this.GroupNumber = groupNumber;
        }

        public string FirstName {get => firstName; set => firstName = value; }        

        public string LastName { get => this.lastName; set => this.lastName = value; }
        // Problem 4
        public int Age { get => this.age; set => this.age = value; }
        // Problem 7
        public string FN { get => this.fn; set => this.fn = value; }

        public string TelNumber { get => this.telNumber; set => this.telNumber = value; }

        public string Email { get => this.email; set => this.email = value; }

        public List<int> Marks { get => this.marks; set => this.marks = value; }

        public int GroupNumber { get => this.groupNumber; set => this.groupNumber = value; }

        // Overrided ToString() method
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Firstname: {this.FirstName} | Lastname: {this.LastName} | Age: {this.Age}");

            if (FN != null)
            {
                sb.AppendLine($"= FN: {this.FN}");
                sb.AppendLine($"= Telephone number: {this.TelNumber}");
                sb.AppendLine($"= Email: {this.Email}");
                sb.AppendLine($"= Group number: {this.GroupNumber}");
                sb.AppendLine($"= Marks: {string.Join(", ", this.Marks)}");                
            }
            return sb.ToString();
        }
    }
}
