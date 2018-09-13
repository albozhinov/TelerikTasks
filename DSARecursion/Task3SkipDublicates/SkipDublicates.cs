using System;

namespace Task3SkipDublicates
{
    class SkipDublicates
    {
        static void Main(string[] args)
        {
            int n = 4;
            int k = 2;

            Skip(new int[k], 0, 1, n);
            Console.WriteLine();
        }
        public static void Skip(int[] combination,int index, int start, int end)
        {
            if (combination.Length == index)
            {
                Console.Write("({0}) ", string.Join(" ", combination));
                return;
            }
            for (int i = start; i <= end; i++)
            {
                combination[index] = i;

                Skip(combination, index + 1, i + 1, end);
            }
        }
    }
}
