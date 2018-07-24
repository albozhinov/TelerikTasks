using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            bool[] primeNums = new bool[N + 1];
            primeNums[0] = true;
            primeNums[1] = true;

            for (int i = 2; i <= N; i++)
            {
                if (!primeNums[i])
                {
                    for (int k = i; k <= N; k += i)
                    {
                        if (k % i == 0 && primeNums[k] == false && k != i)
                        {
                            primeNums[k] = true;
                        }
                    }
                }
            }
            for (long i = N; i >= 0; i--)
            {
                if (!primeNums[i])
                {
                    Console.WriteLine(i);
                    Environment.Exit(0);
                }
            }
        }
    }
}
