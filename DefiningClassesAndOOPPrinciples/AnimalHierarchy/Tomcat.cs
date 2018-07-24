using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age)
        {
            this.Gender = Sex.male;
        }

        public override void Sound()
        {
            Console.WriteLine("Meow - Meow!");
        }
    }
}
