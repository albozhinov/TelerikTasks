using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.MaxSumOfKElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            var elements = new List<int>();           

            for (int i = 0; i < N; i++)
            {
                elements.Add(int.Parse(Console.ReadLine()));                                
            }

            elements.Sort();
            elements.Reverse();
            int sum = 0;
            for (int i = 0; i < K; i++)
            {
                sum += elements[i];
            }
            Console.WriteLine(sum);
        }
    }
}
