using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog(string name, int age)
            : base(name, age)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Croak!");
        }
    }
}
