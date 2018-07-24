using Problem1SchoolCLasses.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

//Disciplines have a name, number of lectures and number of exercises
namespace OOPPrinciples_Part1
{
    public class Disciplines : IComment
    {
        private string name;
        private string comment;
        private int countOfLectures;
        private int countOfExercises;


        // Constructors
        public Disciplines(string name)
        {
            this.name = name;
        }

        public Disciplines(string name, int counOfLectures, int countOfExercise)
            : this(name)
        {
            this.CountOfExercises = countOfExercise;
            this.CountOfLectures = counOfLectures;
        }

        public Disciplines(string name, int counOfLectures, int countOfExercise, string comment)
            :this(name, counOfLectures, countOfExercise)
        {
            this.comment = comment;
        }

        // Properties
        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

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


    }
}
