using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Galaxies
{
    class Program
    {
        private static char[,] matrix;
        private static int maxCounter = 0;

        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rowSize = matrixSize[0];
            int colSize = matrixSize[1];
            matrix = new char[rowSize, colSize];

            FillTheMatrix(rowSize);
            //PrintTheMatrix(matrix);
            var results = new List<int>();
            //Console.WriteLine();


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Solve(i, k, 0);
                    if (maxCounter != 0)
                    {
                        results.Add(maxCounter);
                    }
                    maxCounter = 0;
                }                
            }
           //PrintTheMatrix(matrix);

            Console.WriteLine(string.Join("\n\r", results.OrderByDescending(x => x)));
        }

        public static void Solve(int currRow, int currCol, int counter)
        {
            if (currRow < 0 || currRow >= matrix.GetLength(0) || currCol < 0 || currCol >= matrix.GetLength(1) || matrix[currRow, currCol] == '0')
            {
                return;
            }

            //if (counter > maxCounter)
            //{
            //    maxCounter = counter;
            //}

            if (matrix[currRow, currCol] != '2')
            {
                matrix[currRow, currCol] = '2';
                maxCounter++;

                Solve(currRow, currCol + 1, maxCounter); // Move Right
                Solve(currRow + 1, currCol, maxCounter); // Move Down
                Solve(currRow, currCol - 1, maxCounter); // Move Left
                Solve(currRow - 1, currCol, maxCounter); // Move Up 
            }
        }

        private static void FillTheMatrix(int rowSize)
        {
            for (int i = 0; i < rowSize; i++)
            {
                var inputLine = Console.ReadLine();

                for (int k = 0; k < inputLine.Length; k++)
                {
                    matrix[i, k] = inputLine[k];
                }
            }
        }
        //private static void PrintTheMatrix(char[,] matrix)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < matrix.GetLength(1); col++)
        //        {
        //            sb.Append($"{matrix[row, col]} ");
        //        }
        //        sb.Length--;
        //        sb.AppendLine();
        //    }
        //    Console.Write(sb.ToString());
        //}
    }
}
