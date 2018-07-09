using System;
using System.Linq;

namespace CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputline = Console.ReadLine();

            int countLeft = inputline.Where(x => x == '(').ToArray().Length;
            int countRight = inputline.Where(x => x == ')').ToArray().Length;
            if (countLeft == countRight)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
