using System;
using System.Text;

namespace P01.FillTheMatrix
{
    class Program
    {

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string letter = Console.ReadLine();
            int[,] matrix = new int[N, N];            

            FillMatrix(letter, matrix, N);

            PrintMatrix(N, matrix);
        }

        private static int[,] FillMatrix(string letter, int[,] matrix, int N)
        {
            //int[,] matrix = new int[N, N];
            int counter = 1;

            switch (letter)
            {
                case "a":
                    for (int c = 0; c < N; c++)
                    {
                        for (int r = 0; r < N; r++)
                        {
                            matrix[r, c] = counter++;
                        }
                    }
                    break;
                case "b":
                    for (int col = 0; col < N; col++)
                    {
                        if (col % 2 == 0)
                        {
                            for (int row = 0; row < N; row++)
                            {
                                matrix[row, col] = counter++;
                            }
                        }
                        else
                        {
                            for (int row = N - 1; row >= 0; row--)
                            {
                                matrix[row, col] = counter++;
                            }
                        }
                    }
                        
                    break;
                case "c":
                    //string direction = "Up";
                    int row = N - 1;
                    int col = 0;
                    matrix[row, col] = counter++;

                    for (int i = 0; i < N; i++)
                    {
                         
                    }





                    break;
                case "d":
                    break;
                    
            }
            return matrix;
        }

        private static void PrintMatrix(int N, int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    sb.Append(matrix[row, col] + " ");
                }
                sb.AppendLine();
            }
            Console.Write(sb);
        }
    }
}
