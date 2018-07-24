using System;
using System.Numerics;

namespace Calculate3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            BigInteger factorial = 1;
            for (int i = K + 1; i <= N; i++)
            {
                result = result * i;               
                
            }
            for (int i = 1; i <= N - K; i++)
            {
                factorial = factorial * i;
            }
            result = result / factorial;
            Console.WriteLine(result);
        }
    }
}
