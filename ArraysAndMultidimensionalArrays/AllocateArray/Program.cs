using System;
using System.Text;

namespace ArraysAndMultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                sb.AppendLine((i * 5).ToString());
            }
            Console.Write(sb);
        }
    }
}
