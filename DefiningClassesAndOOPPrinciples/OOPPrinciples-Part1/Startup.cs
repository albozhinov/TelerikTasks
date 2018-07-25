using System;

namespace OOPPrinciples_Part1
{
    class Startup
    {
        static void Main(string[] args)
        {

            School school = new School("Proffesional Economy College");

            Class firstClass = new Class("11 B");
            Class secondClass = new Class("10 A");
            Class thirdClass = new Class("12 D");

            Teacher firstTeacher = new Teacher("Pesho");
            Teacher secondTeacher = new Teacher("Gosho");

            Student firstStudent = new Student("Maria", 13);
            Student secondStudent = new Student("Penka", 2);
            Student thirdStudent = new Student("Blagoi", 32);
            Student forthStudent = new Student("Krasimir", 7);
            Student fifthStudent = new Student("Ivan", 5);

            Disciplines math = new Disciplines("Maths", 5, 10);
            Disciplines history = new Disciplines("History", 3, 6);
            Disciplines geography = new Disciplines("Geography", 3, 6);
            Disciplines literature = new Disciplines("Literature", 2, 4);

            school.AddClass(firstClass);
            school.AddClass(secondClass);
            school.AddClass(thirdClass);

            firstTeacher.AddDiscipline(math);
            firstTeacher.AddDiscipline(literature);
            secondTeacher.AddDiscipline(history);
            secondTeacher.AddDiscipline(geography);

            firstClass.AddStudent(firstStudent);
            firstClass.AddStudent(secondStudent);
            secondClass.AddStudent(thirdStudent);
            thirdClass.AddStudent(forthStudent);
            thirdClass.AddStudent(fifthStudent);

            firstClass.AddTeacher(firstTeacher);
            firstClass.AddTeacher(secondTeacher);
            secondClass.AddTeacher(firstTeacher);
            thirdClass.AddTeacher(secondTeacher);


            school.Print();
        }
    }
}
