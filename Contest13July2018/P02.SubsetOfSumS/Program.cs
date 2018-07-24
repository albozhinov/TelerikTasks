using System;
using System.Linq;

namespace P02.SubsetOfSumS
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            FirstToLast(numbers, S);
            LastToFirst(numbers, S);

            Array.Sort(numbers);

            FirstToLast(numbers, S);
            LastToFirst(numbers, S);
            
            Console.WriteLine("no");
        }

        private static void LastToFirst(int[] numbers, int S)
        {
           int sum = 0;
           int index = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sum = numbers[i];
                for (int k = i - 1 - index; k >= 0; k--)
                {
                    sum += numbers[k];
                    if (sum == S)
                    {
                        Console.WriteLine("yes");
                        Environment.Exit(0);
                    }
                    if (k == 0)
                    {
                        index++;
                        k = i - 1 - index + 1;
                        sum = numbers[i];
                    }
                }
                index = 0;
            }
        }

        private static void FirstToLast(int[] numbers, int S)
        {
            int index = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = numbers[i];
                for (int k = i + 1 + index; k < numbers.Length; k++)
                {
                    sum += numbers[k];

                    if (sum == S)
                    {
                        Console.WriteLine("yes");
                        Environment.Exit(0);
                    }
                    if (k == numbers.Length - 1)
                    {
                        index++;
                        k = i + 1 + index - 1;
                        sum = numbers[i];
                    }
                }
                index = 0;
            }
        }
    }
}
