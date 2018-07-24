using System;
using System.Collections.Generic;

namespace P07.SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < N; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            numbers.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, numbers));
        }
    }
}
