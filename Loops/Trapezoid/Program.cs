using System;

namespace Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            // Top side
            Console.WriteLine(new string('.', N) + new string('*', N));

            //Body
            for (int i = 0; i < N - 1; i++)
            {
                Console.WriteLine(new string('.', N - 1 - i) + '*' + new string('.', N - 1 + i) + "*");
            }
            // Bottom side
            Console.WriteLine(new string('*', 2 * N));
        }
    }
}
