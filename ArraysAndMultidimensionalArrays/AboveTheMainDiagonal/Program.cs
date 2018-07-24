using System;
using System.Numerics;

namespace AboveTheMainDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            BigInteger[,] matrix = FillTheMatrix(size);

            BigInteger sum = 0;
            for (int r = 1; r < size; r++)
            {
                for (int c = 0; c < r; c++)
                {
                    sum += matrix[r, c];
                }
            }
            Console.WriteLine(sum);
        }

        private static BigInteger[,] FillTheMatrix(int size)
        {
            BigInteger[,] matrix = new BigInteger[size, size];
            for (int i = 0; i < size; i++)
            {
                BigInteger number = BigInteger.Pow(2, i);
                for (int k = 0; k < size; k++)
                {
                    matrix[i, k] = number;
                    number =  BigInteger.Pow(2, 1 + i + k);
                }
            }            
            return matrix;
        }
    }
}
