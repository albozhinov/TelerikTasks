using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> arrOfNumbers = new List<int>();
            int result = 0;
            int counter = 1;
            int maxCount = 1;

            for (int i = 0; i < N; i++)
            {
                arrOfNumbers.Add(int.Parse(Console.ReadLine()));
            }            
            arrOfNumbers.Sort();
            for (int i = 0; i < arrOfNumbers.Count - 1; i++)
            {
                if (arrOfNumbers[i] == arrOfNumbers[i + 1])
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        result = arrOfNumbers[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine($"{result}({maxCount} times)");
        }
    }
}
