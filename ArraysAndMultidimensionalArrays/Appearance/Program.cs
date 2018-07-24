using System;
using System.Linq;

namespace Appearance
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfSequence = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string num = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < lenghtOfSequence; i++)
            {
                if (numbers[i].Contains(num))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
