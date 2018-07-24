using Problem1SchoolCLasses.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPPrinciples_Part1
{
    //Teachers have a name. Disciplines have a name, number of lectures and number of exercises
    //Each teacher teaches, a set of disciplines.
    public class Teacher : Person, IComment
    {
        // Fields
        private List<Disciplines> disciplines;
        private int countOfLectures;
        private int countOfExercises;
        private string comment;

        // Constructors
        public Teacher(string name) : base(name)
        {
            this.disciplines = new List<Disciplines>();
        }

        // Properties
        public List<Disciplines> MyDisciplines { get => new List<Disciplines>(this.disciplines); }       

        public int CountOfLectures
        {
            get => this.countOfLectures;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.countOfLectures = value;
            }
        }

        public int CountOfExercises
        {
            get => this.countOfExercises;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.countOfExercises = value;
            }
        }

        public string Comment { get => this.comment; set => this.comment = value; }

        // Methods        
        public void AddDiscipline(Disciplines disciplineName)
        {
            this.disciplines.Add(disciplineName);
        }        
    }
}
