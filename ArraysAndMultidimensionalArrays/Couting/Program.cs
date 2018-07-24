using System;
using System.Text;
using System.Numerics;

namespace Couting
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            input = input.Replace("solve([\"", "");
            input = input.Replace("\"]);", "");

            BigInteger number = BigInteger.Parse(input);

            StringBuilder sb = new StringBuilder();

            for (short i = 0; i < 10; i++)
            {
                sb.AppendLine($"{++number}");
            }
            Console.Write(sb);
        }
    }
}
