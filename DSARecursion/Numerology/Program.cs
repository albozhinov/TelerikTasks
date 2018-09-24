using System;
using System.Collections.Generic;
using System.Linq;

namespace Numerology
{
    class Program
    {
        public static int[] digits = new int[10];

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Select(x => int.Parse(x.ToString())).ToList();

            Recursion(numbers);

            Console.WriteLine(string.Join(" ", digits));
        }

        public static void Recursion(List<int> numbers)
        {
            if (numbers.Count == 1)
            {
                digits[numbers[0]]++;
                return;
            }

            for (int i = 1; i < numbers.Count; i++)
            {
                var a = numbers[i - 1];
                var b = numbers[i];
                numbers.RemoveAt(i);                
                numbers[i - 1] = Calculate(a, b);

                Recursion(numbers);

                numbers[i - 1] = a;
                numbers.Insert(i, b);
            }
        }

        public static int Calculate(int a, int b)
        {
            return (a + b) * (a ^ b) % 10;
        }
    }
}
