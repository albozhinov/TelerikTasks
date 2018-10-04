using System;
using System.Linq;

namespace Portals
{
    class Program
    {
        private static int[,] matrix;
        private static int result = 0;
        private static bool[,] secMatrix;

        static void Main(string[] args)
        {
            var startParams = Console.ReadLine()
                              .Split(new char[] { ' ' },
                              StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToList();

            var startRow = startParams[0];
            var startCol = startParams[1];

            var matrixSize = Console.ReadLine()
                             .Split(new char[] { ' ' },
                             StringSplitOptions.RemoveEmptyEntries)
                             .Select(x => int.Parse(x))
                             .ToList();

            var rowSize = matrixSize[0];
            var colSize = matrixSize[1];

            matrix = new int[rowSize, colSize];
            secMatrix = new bool[rowSize, colSize];

            FillTheMatix(rowSize);

            Solve(startRow, startCol, 0);

            Console.WriteLine(result);
        }

        public static void Solve(int row, int col, int counter)
        {
            // Bottom
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1) || matrix[row, col] == -1)
            {                
                return;
            }

            if (result < counter)
            {
                result = counter;
            }

            if (!secMatrix[row, col])
            {
                secMatrix[row, col] = true;
                counter += matrix[row, col];

                Solve(row + matrix[row, col], col, counter); // Move Down
                Solve(row, col + matrix[row, col], counter); // Move Right
                Solve(row, col - matrix[row, col], counter); // Move Left
                Solve(row - matrix[row, col], col, counter); // Move Up

                secMatrix[row, col] = false;
            }            
        }

        public static void FillTheMatix(int rowSize)
        {
            string[] inputLine;
            for (int row = 0; row < rowSize; row++)
            {
                inputLine = Console.ReadLine()
                            .Split(new char[] { ' ' },
                            StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (inputLine[col] == "#")
                    {
                        matrix[row, col] = -1;
                    }
                    else
                    {
                        matrix[row, col] = int.Parse(inputLine[col]);
                    }
                }
            }
        }

    }
}
