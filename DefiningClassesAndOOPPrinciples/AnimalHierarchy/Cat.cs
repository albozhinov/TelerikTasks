using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(string name, int age)
            : base(name, age)
        {

        }

        public Cat(string name, int age, Sex gender)
            :base(name, age, gender)
        {
            
        }
        
        public override void Sound()
        {
            Console.WriteLine("Miaow!");
        }
    }
}
