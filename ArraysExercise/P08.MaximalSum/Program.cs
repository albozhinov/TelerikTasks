using System;

namespace P08.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var arrOfNumbers = new int[N];
            int sum = 0;
            int maxSum = 0;

            for (int i = 0; i < N; i++)
            {
                arrOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                sum += arrOfNumbers[i];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }

            }



        }
    }
}
