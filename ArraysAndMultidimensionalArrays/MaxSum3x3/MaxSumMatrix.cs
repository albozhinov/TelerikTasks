using System;
using System.Linq;

namespace MaxSum3x3
{
    class MaxSumMatrix
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ');
            short N = short.Parse(nums[0]);
            short M = short.Parse(nums[1]);

            short[,] matrix = new short[N, M];

            for (int r = 0; r < N; r++)
            {
                short[] numbers = Console.ReadLine().Split(' ').Select(short.Parse).ToArray();

                for (int col = 0; col < M; col++)
                {
                    matrix[r, col] = numbers[col];
                }
            }

            short row = 0;
            int currSum = 0;
            int sum = int.MinValue;

            for (int col = 0; col < M - 2; col++)
            {
                for (int k = 0; k < 3; k++)
                {

                    currSum += matrix[row + k, col] + matrix[row + k, col + 1] + matrix[row + k, col + 2];
                }
                if (currSum > sum)
                {
                    sum = currSum;
                }
                currSum = 0;
                if (col == M - 3)
                {
                    row++;
                    col = -1;
                }
                if (row == N - 2)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
