using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace BitShiftMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsCount = int.Parse(Console.ReadLine());
            var colsCount = int.Parse(Console.ReadLine());

            var movesCount = int.Parse(Console.ReadLine());

            var moves = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

            BigInteger[,] matrix = FillTheMatrix(rowsCount, colsCount);
            bool[,] helpMatrix = new bool[rowsCount, colsCount];
            CycleMatrix(moves, helpMatrix);
            BigInteger sum = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (helpMatrix[r,c])
                    {
                        sum += matrix[r, c];
                    }                    
                }
            }
            Console.WriteLine(sum);
        }

        static void CycleMatrix(int[] moves, bool[,] helpMatrix)
        {
            int coeff = Math.Max(helpMatrix.GetLength(0), helpMatrix.GetLength(1));

            int currRow = helpMatrix.GetLength(0) - 1;
            int currCol = 0;
            
            for (int i = 0; i < moves.Length; i++)
            {
                int targetRow = moves[i] / coeff;
                int targerCol = moves[i] % coeff;

                while (targerCol != currCol)
                {
                    if (!helpMatrix[currRow, currCol])
                    {
                        helpMatrix[currRow, currCol] = true;
                    }
                    if (targerCol > currCol)
                    {
                        currCol++;
                    }
                    else
                    {
                        currCol--;
                    }
                }
                while (targetRow != currRow)
                {
                    if (!helpMatrix[currRow, currCol])
                    {
                        helpMatrix[currRow, currCol] = true;
                    }
                    if (currRow < targetRow)
                    {
                        currRow++;
                    }
                    else
                    {
                        currRow--;
                    }
                }
                helpMatrix[currRow, currCol] = true;
            }            
        }

        private static BigInteger[,] FillTheMatrix(int rows, int cols)
        {
            BigInteger[,] matrix = new BigInteger[rows, cols];
            int pow = 0;

            for (int r = rows - 1; r >= 0; r--)
            {
                BigInteger number = BigInteger.Pow(2, pow);

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = number;
                    number = BigInteger.Pow(2, pow + c + 1);

                }
                pow++;
            }            
            return matrix;
        }
    }
}
