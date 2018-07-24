using System;
using System.Linq;
using System.Numerics;


namespace P03.BOunce
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = nums[0];
            int cols = nums[1];

            BigInteger[,] matrix = FillTheMatrix(rows, cols);

            //Find sum!!!
            BigInteger sum = 0;
            int row = 0;
            int col = 0;
            

            while (true)
            {
                while (true)
                {
                    if (row == rows - 1 && col == cols - 1)
                    {
                        sum += matrix[row, col];
                        Console.WriteLine(sum);
                        Environment.Exit(0);
                    }
                    if (row == rows || col == cols)
                    {
                        row--;
                        col--;
                        if (row == 0 && col == 0)
                        {
                            Console.WriteLine(sum);
                            Environment.Exit(0);
                        }
                        row--;
                        col++;
                        break;
                    }                    
                    sum += matrix[row, col];                    
                    row++;
                    col++;
                }                
                while (true)
                {
                    if (row == 0 && col == cols - 1)
                    {
                        sum += matrix[row, col];
                        Console.WriteLine(sum);
                        Environment.Exit(0);
                    }
                    if (row < 0 || col == cols)
                    {
                        row++;
                        col--;
                        row--;
                        col--;
                        break;
                    }
                    sum += matrix[row, col];
                    row--;
                    col++;
                }
                while (true)
                {
                    if (row == 0 && col == 0)
                    {
                        sum += matrix[row, col];
                        Console.WriteLine(sum);
                        Environment.Exit(0);
                    }
                    if (row < 0 || col < 0)
                    {
                        row++;
                        col++;
                        row++;
                        col--;
                        break;
                    }
                    sum += matrix[row, col];
                    row--;
                    col--;
                }
                while (true)
                {
                    if (row == rows - 1 && col == 0)
                    {
                        sum += matrix[row, col];
                        Console.WriteLine(sum);
                        Environment.Exit(0);
                    }
                    if (row == rows || col < 0)
                    {
                        row--;
                        col++;
                        row++;
                        col++;
                        break;
                    }
                    sum += matrix[row, col];
                    row++;
                    col--;

                }

            }
                      
        }

        private static BigInteger[,] FillTheMatrix(int rows, int cols)
        {
            BigInteger[,] matrix = new BigInteger[rows, cols];
            // Fill The Matrix!
            int multiplyer = 1;
            for (int row = 0; row < rows; row++)
            {
                multiplyer = row;

                for (int col = 0; col < cols; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        matrix[row, col] = 1;
                        continue;
                    }
                    matrix[row, col] = (BigInteger)Math.Pow(2, (multiplyer + col));
                }
            }
            return matrix;
        }
    }
}
