using System;
using System.Collections.Generic;
using System.Linq;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<long, int> numbers = new Dictionary<long, int>();                        
            long nextLine;

            for (int i = 0; i < N; i++)
            {
                nextLine = long.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(nextLine))
                {
                    numbers.Add(nextLine, 1);
                    continue;
                }
                numbers[nextLine]++;
            }
            var oddNumer = numbers.First(x => x.Value % 2 == 1);

            Console.WriteLine(oddNumer.Key);           
        }
    }
}
