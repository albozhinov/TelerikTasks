using System;
using System.Text;

namespace ForestRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                sb.AppendLine(new string('.', i) + "*" + new string('.', N - 1 - i));
            }
            for (int i = 1; i < N; i++)
            {
                sb.AppendLine(new string('.', N - 1- i) + "*" + new string('.', i));
            }
            Console.Write(sb);
        }
    }
}
