using System;
using System.Text;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            int row = 0;
            int col = 0;
            string direction = "right";
            

            for (int i = 1; i <= N * N; i++)
            {
                if (direction == "right" && (col > N - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > N - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && row < 0 || matrix[row, col] != 0)
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }
            StringBuilder sb = new StringBuilder();

            
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    sb.Append(matrix[r, c] + " ");                    
                }
                if (r != N - 1)
                {
                    sb.AppendLine();
                }
            }
            Console.WriteLine(sb);
        }
    }
}
