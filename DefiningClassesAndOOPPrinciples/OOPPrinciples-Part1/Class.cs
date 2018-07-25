using Problem1SchoolCLasses.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPrinciples_Part1
{
    //Classes have unique text identifier. Each class has a set of teachers
    public class Class : IComment
    {
        // Fields
        private string textidentifier;
        private string comment;
        private List<Teacher> teachers;
        private List<Student> students;
        
        // Constructors
        public Class(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        public Class(string textIdentifier, string comment) : this(textIdentifier)
        {
            this.comment = comment;
        }

        // Properties
        public string TextIdentifier
        {
            get
            {
                return this.textidentifier;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }                

                this.textidentifier = value;
            }
        }
        
        public List<Teacher> Teachers { get => new List<Teacher>(this.teachers); }

        public List<Student> Students { get => new List<Student>(this.students); }

        public string Comment { get => this.comment; set => this.comment = value; }

        // Methods
        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        } 
        
        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" #Class identifier: {this.TextIdentifier}");
            sb.AppendLine("  #Teachers:");

            foreach (var teacher in Teachers)
            {
                sb.AppendLine($"   -Name: {teacher.Name}\r\n   -Number of lectures: {teacher.CountOfLectures}\r\n   -Number of exercises: {teacher.CountOfExercises}\r\n   -Disciplines:\r\n    {teacher.Print()}");
            }

            sb.AppendLine("  #Students:");

            foreach (var student in Students)
            {
                sb.AppendLine($"   -Name: {student.Name}, ID: {student.UniqueNumber};");
            }

            return sb.ToString();
        }

    }
}



