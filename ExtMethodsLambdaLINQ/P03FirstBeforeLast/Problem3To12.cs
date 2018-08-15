using System;
using System.Linq;
using System.Collections.Generic;

namespace P03FirstBeforeLast
{
    public class Problem3To12
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            { new Student("Alex", "Bozhinov", 27),
              new Student("Alex", "Angelov", 20),
              new Student("Daniel", "Grozdanov", 19),
              new Student("Svetoslav", "Ivanov", 28),
              new Student("Ivailo", "Kenov", 29),
              new Student("Nikolay", "Kostov", 25),
              new Student("Volen", "Pavlov", 35),
              new Student("Ivomir", "Assi", 30),
              new Student("Nikolay", "Paraskevov", 28),
              new Student("Nikolay", "Georgiev", 45),
              new Student("Georgi", "Kostov", 21)
            };

            //Print all student
            Console.WriteLine("==== All students");
            PrintCollection(students);
            Console.WriteLine(new string('=', 50));

            // Problem 3 FirstBeforeLast
            Console.WriteLine("==== Problem 3 (First name before last name alphabetically)");
            var result = FirstBeforeLast(students);
            PrintCollection(result);
            Console.WriteLine(new string('=', 50));

            // Problem 4 Age range
            Console.WriteLine("==== Problem 4 (Students between 18 and 24 years old)");
            PrintCollection(students.Where(x => x.Age >= 18 && x.Age <= 24));
            Console.WriteLine(new string('=', 50));

            // Problem 5 Order Students
            Console.WriteLine("==== Problem 5 (Order Students)");
            PrintCollection(students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName));
            Console.WriteLine(new string('=', 50));
            
            List<Student> myStudents = new List<Student>
            { new Student("Alex", "Bozhinov", 27, "00001", "02886123456",
                          "alex.Bozhinov@abv.bg", new List<int> {2, 5, 2, 3 }, 2),
              new Student("Alex", "Angelov", 20, "00002", "+359886123457",
                          "alex.Angelov@yahoo.com", new List<int> {5, 5, 6, 5, 3, 5, 4, 6, 6 }, 2),
              new Student("Daniel", "Grozdanov", 19, "00012", "+359885123327",
                          "daniel.BayGrozdan@abv.bg", new List<int> {2, 5, 6, 5, 3, 6, 4, 6 }, 3),
              new Student("Svetoslav", "Ivanov", 28, "00010", "+02887123328",
                          "svetosval.Ivanov@yahoo.com", new List<int> {3, 5, 6, 6, 3, 5, 6, 4 }, 5),
              new Student("Ivailo", "Kenov", 29, "00011", "+359889123427",
                          "ivailo.Kenov@abv.bg", new List<int> {6, 6, 6, 6, 6, 6, 6, 6 }, 2),
              new Student("Nikolay", "Kostov", 25, "00011", "+359889123427",
                          "niki.GotinSUm@gmail.com", new List<int> {6, 6, 6, 6, 6, 6, 6, 6 }, 2),
              new Student("Volen", "Pavlov", 35, "00011", "+359889123427",
                          "volen.FIki@abv.bg", new List<int> {3, 3, 3, 3, 3, 3, 3, 3 }, 7),
              new Student("Ivomir", "Assi", 30, "00011", "+359889123427",
                          "ivomir.Barabata@hotmail.bg", new List<int> {3, 3, 3, 4, 3, }, 4),
              new Student("Nikolay", "Paraskevov", 28, "00011", "+359889123557",
                          "cherniki.Shiki@abv.bg", new List<int> {3, 4, 2, 3, 5, 5, 4, 6 }, 9),
              new Student("Nikolay", "Georgiev", 45, "00011", "02889133427",
                          "nikolay.Georgiev@hotmail.bg", new List<int> {6, 4, 2, 6, 5, 3, 5, 4 }, 1),
              new Student("Georgi", "Kostov", 21, "00011", "02889111427",
                          "georgi.Kostov@gmail.com", new List<int> {2, 3, 2, 4, 4, 3, 4, 3 }, 6)
            };

            // Problem 7 Students gropus
            Console.WriteLine("==== Problem 7 (Students group)");
            PrintCollection(myStudents.Where(x => x.GroupNumber == 2).OrderByDescending(x => x.FirstName));
            Console.WriteLine(new string('=', 50));

            // Problem 9 Extract students by email
            Console.WriteLine("==== Problem 9 (Extract students by email)");
            PrintCollection(myStudents.Where(x => x.Email.EndsWith("@abv.bg")));
            Console.WriteLine(new string('=', 50));

            // Problem 10 Extract students by phone
            Console.WriteLine("==== Problem 10 (Extract students by phone)");
            PrintCollection(myStudents.Where(x => x.TelNumber.StartsWith("02")));
            Console.WriteLine(new string('=', 50));

            // Problem 11 Extract students by marks
            Console.WriteLine("==== Problem 11 (Extract students by marks)");
            PrintCollection(myStudents.Where(x => x.Marks.Average() == 6)); // .Contains is default description
            Console.WriteLine(new string('=', 50));

            // Problem 12 Extract students with two marks
            Console.WriteLine("==== Problem 12 (Extract students with two marks)");
            PrintCollection(myStudents.Where(x => x.Marks.Contains(2)));
            Console.WriteLine(new string('=', 50));

        }

        // Problem 3 FirstBeforeLast
        private static IEnumerable<Student> FirstBeforeLast(IEnumerable<Student> students)
        {           
            var result = students.Where(x => x.FirstName[0] <= x.LastName[0]).ToList();
            return result;
        }
        // Help print method
        public static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
