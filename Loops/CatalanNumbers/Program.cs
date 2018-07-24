using System;
using System.Numerics;

namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger[] catalan = new BigInteger[N + 1];
            BigInteger lastCatalan = 1;
            catalan[0] = lastCatalan;

            for (int i = 1; i <= N; i++)
            {
                lastCatalan = (2 * (2 * i - 1) * lastCatalan) / (i + 1);
                catalan[i] = lastCatalan;
            }
            Console.WriteLine(catalan[N]);
        }
    }
}
