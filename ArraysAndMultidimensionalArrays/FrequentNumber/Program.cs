using System;

namespace FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            short N = short.Parse(Console.ReadLine());
            short[] numbers = new short[10001];
            short mostNum = 0;
            short mostCount = 0;
            for (short i = 0; i < N; i++)
            {
                short num = short.Parse(Console.ReadLine());
                numbers[num]++;
                if (numbers[num] > mostCount)
                {
                    mostCount = numbers[num];
                    mostNum = num;
                }
            }
            Console.WriteLine($"{mostNum} ({mostCount} times)");
        }
    }
}

