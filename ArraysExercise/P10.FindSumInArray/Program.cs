using System;
using System.Collections.Generic;
using System.Linq;

namespace P10.FindSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int S = int.Parse(Console.ReadLine());
            int sum = 0;
            int startIndex = 0;
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = numbers[i];
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    sum += numbers[k];
                    if (sum == S)
                    {
                        startIndex = i;
                        count = k - i + 1;                        
                        Console.WriteLine(string.Join(", ", numbers.Select(x => x.ToString()).ToArray(), startIndex, count));
                        return;
                    }
                }
            }
        }
    }
}
