using System;

namespace P01.AllocatArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i * 5;
                Console.WriteLine(numbers[i]);
            }            
        }
    }
}
