using System;
using System.Linq;
using System.Numerics;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int moves = int.Parse(Console.ReadLine());

            var codes = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var coef = Math.Max(r, c);

            BigInteger sum = 0;


            for (int i = 0; i < codes.Length; i++)
            {
                var row = codes[i] / coef;
                var col = codes[i] % coef;





            }


        }
    }
}
