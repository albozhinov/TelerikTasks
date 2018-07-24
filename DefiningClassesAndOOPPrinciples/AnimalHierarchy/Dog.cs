using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Sex gender)
            : base(name, age, gender)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Wow - wow!");
        }
    }
}
