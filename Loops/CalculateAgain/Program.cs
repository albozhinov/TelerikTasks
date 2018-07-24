using System;
using System.Numerics;

namespace CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var K = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            
            for (int i = K + 1; i <= N; i++)
            {
                result = result * i;
            }           

            Console.WriteLine(result);
        }
    }
}
