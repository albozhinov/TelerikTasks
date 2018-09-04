using System;
using System.Linq;
using System.Collections.Generic;

namespace Task1
{
    class SumAndAverage
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var sequence = new List<int>();

            while (true)
            {
                if (inputLine == "" || inputLine == " ")
                {
                    break;
                }
                sequence.Add(int.Parse(inputLine));
                inputLine = Console.ReadLine();
            }
            Console.WriteLine("Sum: {0}", sequence.Sum());
            Console.WriteLine("Average: {0}", sequence.Average());
        }
    }
}
