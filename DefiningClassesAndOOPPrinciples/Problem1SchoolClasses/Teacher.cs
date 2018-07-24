using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPPrinciples_Part1
{
    //Teachers have a name. Disciplines have a name, number of lectures and number of exercises
    //Each teacher teaches, a set of disciplines.
    public class Teacher : Person
    {
        private List<Disciplines> myDisciplines;

        public List<Disciplines> MyDisciplines
        {
            get => new List<Disciplines>(this.myDisciplines);
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.myDisciplines = value;
            }
        }

        public void AddDiscipline(string disciplineName, int countOfLectures, int countOfExercise)
        {
            if (!MyDisciplines.Any(d => d.DisciplineName == disciplineName))
            {
                Disciplines newDis = new Disciplines(disciplineName, countOfLectures, countOfExercise);
                MyDisciplines.Add(newDis);
            }
        }

        public Teacher(string name) : base(name)
        {
            this.MyDisciplines = new List<Disciplines>();
        }
    }
}
