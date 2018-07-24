using System;
using System.Collections.Generic;

namespace PrimeToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> primeNums = new List<int>();
            bool[] isPrime = new bool[N + 1];

            for (int i = 0; i <= N; i++)
            {
                isPrime[i] = true;
            }
            isPrime[0] = false;
            isPrime[1] = false;            

            for (int i = 2; i <= N; i++)
            {
                if (isPrime[i])
                {
                    int multiplier = i;
                    primeNums.Add(i);

                    for (int k = i + multiplier; k <= N; k += multiplier)
                    {
                        if (k % multiplier == 0)
                        {
                            isPrime[k] = false;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", primeNums));
        }
    }
}
