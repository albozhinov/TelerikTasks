using System;

namespace FillMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];

            int row = n - 1;
            int col = 0;
            int data = 0;

            for (int i = 0; i < n; i++)
            {
                do
                {
                    data++;
                    if (row < 0)
                    {
                        row = 0;
                    }
                    
                    array[row, col] = data;
                    row++;
                    col++;
                }
                while (row < n);

                row -= col + 1;
                col = 0;
            }

            row = 0;
            col = 1;
            for (int i = 0; i < n - 1; i++)
            {
                do
                {
                    data++;
                    array[row, col] = data;
                    row++;
                    col++;
                } while (col < n);

                col -= row - 1;
                row = 0;
            }

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write(array[i,k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

