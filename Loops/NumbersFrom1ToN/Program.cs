using System;
using System.Text;

namespace NumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                sb.Append(i + " ");
            }
            Console.WriteLine(sb);
        }
    }
}
