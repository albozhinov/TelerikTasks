using System;
using System.Collections.Generic;
using System.Text;

namespace Task2CombinationWithDublicates
{
    class CombinationWithDublicates
    {
        static void Main(string[] args)
        {
            int N = 3;
            int K = 2;

            GenerateCombination(new int[K], 0, 1, N);
            Console.WriteLine();
        }

        private static void GenerateCombination(int[] combination, int index, int start, int end)
        {
            if (index == combination.Length)
            {
                Console.Write("({0}), ", string.Join(" ", combination));
                return;
            }
            for (int i = start; i <= end; i++)
            {
                combination[index] = i; 
                GenerateCombination(combination, index + 1, i, end);
            }
        }
    }
}
