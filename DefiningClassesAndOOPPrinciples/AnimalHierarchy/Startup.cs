using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalHierarchy
{
    class Startup
    {
        static void Main()
        {
            // Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

            Cat[] cats =
            {
                new Cat("Blacky", 4, Sex.female),
                new Cat("Maca", 5, Sex.female),
                new Cat("Chocho", 7, Sex.male),
                new Kitten("Snejina", 1),
                new Kitten("Snejka", 1),
                new Kitten("Sneji",  2),
                new Tomcat("Tomas", 5),
                new Tomcat("Tomi", 8),
                new Tomcat("Pesho", 10)
            };

            Dog[] dogs =
            {
                new Dog("Sami", 4, Sex.male),
                new Dog("Rita", 10, Sex.female),
                new Dog("Lacy", 9, Sex.male),
            };

            Frog[] frogs =
            {
                new Frog("Rabi", 2),
                new Frog("Gosho", 8),
                new Frog("Penka", 7)
            };

            List<Animal> allAnimals = new List<Animal>();
            allAnimals.AddRange(cats);
            allAnimals.AddRange(dogs);
            allAnimals.AddRange(frogs);

            Console.WriteLine("Average age of cats is {0} years.", CalcAverageYears(cats));
            Console.WriteLine("Average age of dogs is {0} years.", CalcAverageYears(dogs));
            Console.WriteLine("Average age of frogs is {0} years.", CalcAverageYears(frogs));

            Console.WriteLine("Cats sound:");
            cats[0].Sound();
            Console.WriteLine("Kitten sound:");
            cats[4].Sound();
            Console.WriteLine("Tomcats sound:");
            cats[7].Sound();
            Console.WriteLine("Dogs sound:");
            dogs[0].Sound();
            Console.WriteLine("Frogs sound:");
            frogs[0].Sound();            

        }
        public static double CalcAverageYears(Animal[] animlas)
        {
            return Math.Round(animlas.Average(x => x.Age));
        }
    }
}
