using System;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int number;
            int[] numbers = new int[N * 2];
            for (int i = 0; i < N * 2; i++)
            {
                number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            bool isEqual = true;

            for (int i = 0; i < N / 2; i++)
            {
                if (numbers[i] != numbers[N + i])
                {
                    isEqual = false;
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
