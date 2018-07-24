using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        // Fields
        private int age;
        private string name;
        private Sex gender;

        // Properties
        public int Age
        {
            get => this.age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.age = value;
            }
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.name = value;
            }
        }

        public Sex Gender
        {
            get => this.gender;
            set
            {
                Sex sexParsed;
                if (!Enum.TryParse(value.ToString(), out sexParsed))
                {
                    throw new ArgumentException();
                }
                this.gender = sexParsed;
            }
            
        }

        // Constructors

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;            
        }

        public Animal(string name, int age, Sex gender)
            : this(name, age)
        {
            this.Gender = gender;
        }

        public abstract void Sound();    

        public virtual string Print()
        {
            return $"#Animal: {this.Name}\r\n #Age: {this.Age}\r\n #Sex: {this.Gender}";
        }
    }
}
