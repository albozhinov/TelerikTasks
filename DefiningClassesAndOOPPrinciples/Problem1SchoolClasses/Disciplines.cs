using System;
using System.Collections.Generic;
using System.Text;

//Disciplines have a name, number of lectures and number of exercises
namespace OOPPrinciples_Part1
{
    public class Disciplines
    {
        private string disciplineName;
        private int countOfLectures;
        private int countOfExercises;

        public string DisciplineName
        {
            get => this.disciplineName;
            set
            {
                if (value == null || value.Length <= 3)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.disciplineName = value;
            }
        }

        public int CountOfLectures
        {
            get => this.countOfLectures;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
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
                    throw new ArgumentOutOfRangeException();
                }
                this.countOfExercises = value;
            }
        }
        public Disciplines()
        {

        }

        public Disciplines(string name, int countOfLectures, int countOfExercises) : this()
        {
            this.disciplineName = name;
            this.CountOfExercises = countOfExercises;
            this.CountOfLectures = countOfLectures;
        }
    }
}
