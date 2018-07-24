using System;
using System.IO;
using System.Linq;

namespace SequenceInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int bufSize = 1024;
            Stream inStream = Console.OpenStandardInput(bufSize);
            Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));            

            var inputLine = Console.ReadLine().Split(' ').Select(x => byte.Parse(x)).ToArray();
            var rows = inputLine[0];
            var columns = inputLine[1];
            int[,] matrix = FillTheMatrix(rows, columns);
            byte mostRow = FindRowMostSeq(matrix);
            byte mostColumn = FindColMostSeq(matrix);
            byte mostDiagonal = FindDiagonalMostSeq(matrix);

            byte result = Math.Max(mostRow, mostColumn);
            byte maxFreqSeq = Math.Max(result, mostDiagonal);

            Console.WriteLine(maxFreqSeq);
        }

        private static byte FindDiagonalMostSeq(int[,] matrix)
        {
            byte mostFreqSeq = 0;
            byte curCounter = 1;
            var row = 0;
            var col = 0;
            var nextCol = 1;

            //Above diagonal!!!
            while (true)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    curCounter++;
                    if (curCounter > mostFreqSeq)
                    {
                        mostFreqSeq = curCounter;
                    }                    
                }
                else
                {
                    curCounter = 1;
                }
                row++;
                col++;
                if (row + 1 == matrix.GetLength(0) && col + 1 == matrix.GetLength(1))
                {
                    row = 0;
                    col = 1;                    
                }
                else if (col + 1 == matrix.GetLength(1) || row + 1 == matrix.GetLength(0))
                {
                    nextCol++;
                    row = 0;
                    col = nextCol;                    
                }
                if (nextCol == matrix.GetLength(1) - 1)
                {
                    break;
                }
            }
            //Bottom diagonal!!!
            row = 1;
            col = 0;
            var nexRow = 2;
            while (true)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    curCounter++;
                    if (curCounter > mostFreqSeq)
                    {
                        mostFreqSeq = curCounter;
                    }
                }
                else
                {
                    curCounter = 1;
                }
                row++;
                col++;
                if (row + 1 == matrix.GetLength(0) || col + 1 == matrix.GetLength(1))
                {
                    row = nexRow;
                    col = 0;
                    nexRow++;
                }
                if (nexRow == matrix.GetLength(0) - 1)
                {
                    break;
                }
            }

            row = matrix.GetLength(0) - 1;
            col = 0;
            nextCol = 2;
            //Bottom
            while (true)
            {
                if (matrix[row,col] == matrix[row - 1, col + 1])
                {
                    curCounter++;
                    if (curCounter > mostFreqSeq)
                    {
                        mostFreqSeq = curCounter;
                    }
                }
                else
                {
                    curCounter = 1;
                }
                row--;
                col++;
                if (row - 1 == 0 && col + 1 == matrix.GetLength(1))
                {
                    row = matrix.GetLength(0) - 1;
                    col = 1;
                }
                else if (col + 1 == matrix.GetLength(1) || row == 0)
                {
                    row = matrix.GetLength(0) - 1;
                    col = nextCol;
                    nextCol++;
                }
                if (nextCol == matrix.GetLength(1) - 1)
                {
                    break;
                }
            }

            nexRow = 1;
            row = matrix.GetLength(0) - nexRow;
            col = 0;

            while (true)
            {
                if (matrix[row, col] == matrix[row - 1, col + 1])
                {
                    curCounter++;
                    if (curCounter > mostFreqSeq)
                    {
                        mostFreqSeq = curCounter;
                    }
                }
                else
                {
                    curCounter = 1;
                }
                row--;
                col++;
                if (row ==  0 || col + 1 == matrix.GetLength(1))
                {
                    nexRow++;
                    row = matrix.GetLength(0) - nexRow;
                    col = 0;                    
                }
                if (nexRow == matrix.GetLength(0) - 1)
                {
                    break;
                }
            }
            return mostFreqSeq;
        }

        private static byte FindColMostSeq(int[,] matrix)
        {
            byte mostFreqSeq = 0;
            byte currCounter = 1;
            //int num = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[rows, col] == matrix[rows, col + 1])
                    {
                        currCounter++;
                        if (currCounter > mostFreqSeq)
                        {
                            mostFreqSeq = currCounter;
                            //num = matrix[row, col]; Най - често срещаното число!
                        }
                    }
                    else
                    {
                        currCounter = 1;
                    }
                }

            //Console.WriteLine(num);
            return mostFreqSeq;
        }

        private static byte FindRowMostSeq(int[,] matrix)
        {
            byte mostFreqSeq = 0;
            byte currCounter = 1;
            //int num = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        currCounter++;
                        if (currCounter > mostFreqSeq)
                        {
                            mostFreqSeq = currCounter;
                            //num = matrix[row, col]; Най - често срещаното число!
                        }
                    }
                    else
                    {
                        currCounter = 1;
                    }
                }

            //Console.WriteLine(num);
            return mostFreqSeq;
        }

        private static int[,] FillTheMatrix(byte rows, byte columns)
        {
            int[,] matrix = new int[rows, columns];

            for (byte row = 0; row < rows; row++)
            {
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (byte col = 0; col < columns; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            return matrix;
        }
    }
}
