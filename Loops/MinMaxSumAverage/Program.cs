using System;

namespace MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            double sum = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            double avg = 0;

            for (int i = 0; i < N; i++)
            {
                var num = double.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            avg = sum / N;

            Console.WriteLine($"min={min:F2}");
            Console.WriteLine($"max={max:F2}");
            Console.WriteLine($"sum={sum:F2}");
            Console.WriteLine($"avg={avg:F2}");
        }
    }
}
