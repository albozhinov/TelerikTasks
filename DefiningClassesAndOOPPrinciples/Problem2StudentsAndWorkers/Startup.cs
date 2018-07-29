using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2StudentsAndWorkers
{
    class Startup
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();

            allStudents.Add(new Student("Peter", "Petrov", 5));
            allStudents.Add(new Student("Georgi", "Georgiev", 6));
            allStudents.Add(new Student("Penka", "Penkova", 3));
            allStudents.Add(new Student("Ivan", "Ivanov", 5));
            allStudents.Add(new Student("Stamat", "Stamatov", 4));
            allStudents.Add(new Student("Moisei", "Moiseev", 5));
            allStudents.Add(new Student("Pencho", "Penchev", 5));
            allStudents.Add(new Student("Hristo", "Hristov", 6));
            allStudents.Add(new Student("Krasimir", "Krasimirov", 4));
            allStudents.Add(new Student("Maria", "Petrova", 4));

            foreach (Student student in allStudents.OrderBy(x => x.Grade))
            {
                Console.WriteLine($"{student.Firstname} {student.Lastname} grade: {student.Grade}");
            }
            Console.WriteLine();
            List<Worker> allWorkers = new List<Worker>();

            allWorkers.Add(new Worker("Dragan", "Draganov", 403, 8));
            allWorkers.Add(new Worker("Blagoi", "Blagoev", 400, 8));
            allWorkers.Add(new Worker("Daniela", "Danielova", 450, 6));
            allWorkers.Add(new Worker("Mario", "Petrov", 500, 12));
            allWorkers.Add(new Worker("Vasil", "Vasilev", 400, 6));
            allWorkers.Add(new Worker("Peicho", "Peichev", 500, 8));
            allWorkers.Add(new Worker("Ivan", "Petrov", 250, 6));
            allWorkers.Add(new Worker("Georgi", "Petrov", 200, 8));
            allWorkers.Add(new Worker("Reni", "Georgieva", 600, 8));
            allWorkers.Add(new Worker("Gergana", "Georgieva", 750, 6));
            
            foreach (Worker worker in allWorkers.OrderByDescending(w => w.MoneyPerHour()))
            {
                Console.WriteLine($"{worker.Firstname} {worker.Lastname} => money per hour: {worker.MoneyPerHour()}");
            }
            Console.WriteLine();
            List<Human> mergedList = new List<Human>(); 
            mergedList.AddRange(allStudents);
            mergedList.AddRange(allWorkers);            

            foreach (Human person in mergedList.OrderBy(x => x.Firstname).ThenBy(y => y.Lastname))
            {
                Console.WriteLine($"{person.Firstname} {person.Lastname}");
            }
        }
    }
}
