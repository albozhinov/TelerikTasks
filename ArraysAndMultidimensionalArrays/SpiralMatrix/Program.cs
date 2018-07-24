using System;
using System.Text;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];            

            int topRow = 0;
            int rightCol = N - 1;
            int leftCol = 0;
            int bottomRow = N - 1;
            int number = 1;

            for (int i = 0; i < (N / 2) + 1; i++)
            {
                for (int col = leftCol; col <= rightCol; col++)
                {
                    matrix[topRow, col] = number++;
                }
                topRow++;

                for (int row = topRow; row <= bottomRow; row++)
                {
                    matrix[row, rightCol] = number++;
                    
                }
                rightCol--;

                for (int col = rightCol; col >= leftCol; col--)
                {
                    matrix[bottomRow, col] = number++;
                    
                }
                bottomRow--;

                for (int row = bottomRow; row >= topRow; row--)
                {
                    matrix[row, leftCol] = number++;
                }
                leftCol++;

                if (number == N * N )
                {
                    break;
                }
            }
            // Print The Matrix
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    sb.Append(matrix[row, col] + " ");
                }
                sb.AppendLine();
            }
            Console.Write(sb.ToString());
        }
    }
}
