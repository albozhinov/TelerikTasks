using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Sex gender;

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

        public string Gender
        {
            get => this.gender.ToString();
            set
            {
                Sex sexParsed;
                if (!Enum.TryParse(value, out sexParsed))
                {
                    throw new ArgumentException();
                }
                this.gender = sexParsed;
            }
            
        }
        
        public abstract void Sound();    
    }
}
