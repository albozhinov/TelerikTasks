using System;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());
            long factorial = 1;
            double S = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial = factorial * i;
                S += factorial / Math.Pow(X, i);
            }
            Console.WriteLine($"{S:F5}");
        }
    }
}
