using System;
using System.Text;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            int row = N - 1;
            int col = 0;
            int number = 1;

            for (int c = 1; c <= N; c++)
            {
                for (int r = 0; r < c; r++)
                {
                    matrix[row, col] = number++;
                    row++;
                    col++;
                }
                row = N - 1 - c;
                col = 0;
            }

            for (int i = 1; i < N; i++)
            {
                row = 0;
                col = i;

                for (int c = N - 1; c >= 0 + i; c--)
                {
                    matrix[row, col] = number++;
                    row++;
                    col++;
                }
            }
            // Print The Matrix
            StringBuilder sb = new StringBuilder();
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    sb.Append(matrix[r, c] + " ");
                }
                sb.AppendLine();
            }
            Console.Write(sb);
        }
    }
}
