using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age)
        {
            this.Gender = Sex.female;
        }

        public override void Sound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
