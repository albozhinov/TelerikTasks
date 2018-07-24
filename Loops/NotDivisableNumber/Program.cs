using System;
using System.Text;

namespace NotDivisableNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                sb.Append(i + " ");
            }
            Console.WriteLine(sb);
        }
    }
}
